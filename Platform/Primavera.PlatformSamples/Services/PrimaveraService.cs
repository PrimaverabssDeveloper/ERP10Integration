using ErpBS100;
using Primavera.PlatformSamples.Models;
using StdBE100;
using StdPlatBS100;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Primavera.PlatformSamples.Services
{
    public class PrimaveraService
    {
        private readonly Random _random = new Random();

        // ── Client list ───────────────────────────────────────────────────────
        public List<Cliente> ObterClientes()
        {
            try
            {
                StdBEFiltroListagem stdBEFiltroListagem = new StdBEFiltroListagem();
                stdBEFiltroListagem.FiltroWhere =
                    "Cliente IN (SELECT DISTINCT Entidade FROM CabecDoc C WHERE C.Data >= DATEADD(MONTH, -48, CAST(GETDATE() AS DATE)) AND C.Data < CAST(GETDATE() AS DATE))";

                return PriEngine.Engine.Base.Clientes
                    .ListaClientes(stdBEFiltroListagem)
                    .Select(a => new Cliente
                    {
                        Codigo = a.Cliente,
                        Nome = a.Nome,
                        Nif = a.NumContribuinte,
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // ── Credit risk report ────────────────────────────────────────────────
        public string ExecutarPrompt(string Cliente)
        {
            try
            {
                string sql = $@"DECLARE @Cliente NVARCHAR(20) = '{Cliente}';

;WITH Cliente AS (
    SELECT
        C.Cliente,
        C.Nome,
        LimiteCredito = ISNULL(C.LimiteCred, 0),
        C.CondPag,
        CondPagDescricao = CP.Descricao,
        PrazoPagamentoDias = CP.Dias
    FROM Clientes C
    LEFT JOIN CondPag CP
        ON CP.CondPag = C.CondPag
    WHERE C.Cliente = @Cliente
),

ContaCorrente AS (
    SELECT
        H.Id,
        H.Entidade,
        H.DataDoc,
        H.DataVenc,
        H.ValorTotal,
        ValorPendente = ISNULL(P.ValorPendente, 0),
        ValorLiquidado = H.ValorTotal - ISNULL(P.ValorPendente, 0),
        H.DataLiq,
        Pago = CASE 
            WHEN P.IdHistorico IS NULL THEN 1 
            ELSE 0 
        END
    FROM Historico H
    LEFT JOIN Pendentes P
        ON P.IdHistorico = H.Id
    WHERE H.TipoEntidade = 'C'
      AND H.Modulo = 'V'
      AND H.Entidade = @Cliente
),

ResumoDivida AS (
    SELECT
        Entidade,
        SaldoAtualEmDivida = SUM(ValorPendente),
        NumeroFaturasVencidasNaoPagas = SUM(
            CASE 
                WHEN ValorPendente > 0 
                 AND DataVenc < CAST(GETDATE() AS DATE)
                THEN 1 
                ELSE 0 
            END
        ),
        ValorFaturasVencidasNaoPagas = SUM(
            CASE 
                WHEN ValorPendente > 0 
                 AND DataVenc < CAST(GETDATE() AS DATE)
                THEN ValorPendente 
                ELSE 0 
            END
        )
    FROM ContaCorrente
    GROUP BY Entidade
),

AtrasosPagamento AS (
    SELECT
        Entidade,
        DiasMediosAtrasoPagamento12M = AVG(
            CAST(
                CASE 
                    WHEN DataLiq IS NOT NULL
                     AND DataVenc IS NOT NULL
                     AND DataLiq > DataVenc
                    THEN DATEDIFF(DAY, DataVenc, DataLiq)
                    ELSE 0
                END AS DECIMAL(18, 2)
            )
        )
    FROM ContaCorrente
    WHERE Pago = 1
      AND DataLiq >= DATEADD(MONTH, -12, CAST(GETDATE() AS DATE))
    GROUP BY Entidade
),

EncomendasAbertas AS (
    SELECT
        C.Entidade,
        ValorEncomendasAbertas = SUM(ISNULL(C.TotalDocumento, 0))
    FROM CabecDoc C
    INNER JOIN CabecDocStatus S
        ON S.IdCabecDoc = C.Id
    INNER JOIN DocumentosVenda D
        ON D.Documento = C.TipoDoc
    WHERE C.TipoEntidade = 'C'
      AND C.Entidade = @Cliente
      AND D.TipoDocumento = 2
      AND S.Estado = 'P'
      AND ISNULL(S.Anulado, 0) = 0
    GROUP BY C.Entidade
)

SELECT
    CL.Cliente,
    CL.Nome,
    CL.LimiteCredito,
    CL.CondPag,
    CL.CondPagDescricao,
    CL.PrazoPagamentoDias,
    SaldoAtualEmDivida           = ISNULL(RD.SaldoAtualEmDivida, 0),
    NumeroFaturasVencidasNaoPagas = ISNULL(RD.NumeroFaturasVencidasNaoPagas, 0),
    ValorFaturasVencidasNaoPagas  = ISNULL(RD.ValorFaturasVencidasNaoPagas, 0),
    DiasMediosAtrasoPagamento12M  = ISNULL(AP.DiasMediosAtrasoPagamento12M, 0),
    ValorEncomendasAbertas        = ISNULL(EA.ValorEncomendasAbertas, 0),
    ExposicaoTotalAtual =
        ISNULL(RD.SaldoAtualEmDivida, 0) + ISNULL(EA.ValorEncomendasAbertas, 0),
    PercentagemUtilizacaoPlafond =
        CASE 
            WHEN CL.LimiteCredito > 0 THEN
                CAST(
                    (ISNULL(RD.SaldoAtualEmDivida, 0) + ISNULL(EA.ValorEncomendasAbertas, 0))
                    * 100.0 / CL.LimiteCredito AS DECIMAL(18, 2)
                )
            ELSE NULL
        END
FROM Cliente CL
LEFT JOIN ResumoDivida RD    ON RD.Entidade = CL.Cliente
LEFT JOIN AtrasosPagamento AP ON AP.Entidade = CL.Cliente
LEFT JOIN EncomendasAbertas EA ON EA.Entidade = CL.Cliente;";

                // ── Build context and prompt strings ─────────────────────────
                DataTable resultado = PriEngine.Engine.ConsultaDataTable(sql);

                if (resultado == null || resultado.Rows.Count == 0)
                    return null;

                DataRow row = resultado.Rows[0];

                string Nome = row["Nome"].ToString();
                string LimiteCredito = row["LimiteCredito"].ToString();
                string CondPag = row["CondPag"].ToString();
                string CondPagDescricao = row["CondPagDescricao"].ToString();
                string PrazoPagamentoDias = row["PrazoPagamentoDias"].ToString();
                string SaldoAtualEmDivida = row["SaldoAtualEmDivida"].ToString();
                string NumeroFaturasVencidasNaoPagas = row["NumeroFaturasVencidasNaoPagas"].ToString();
                string ValorFaturasVencidasNaoPagas = row["ValorFaturasVencidasNaoPagas"].ToString();
                string DiasMediosAtrasoPagamento12M = row["DiasMediosAtrasoPagamento12M"].ToString();
                string ValorEncomendasAbertas = row["ValorEncomendasAbertas"].ToString();
                string ExposicaoTotalAtual = row["ExposicaoTotalAtual"].ToString();
                string PercentagemUtilizacaoPlafond = row["PercentagemUtilizacaoPlafond"].ToString();

                //string contextData = DataTableToCsv(resultado);

                string txtContext = $@"## Contexto — Resultado da query de risco de crédito (Primavera Executive ERPv10)

A query executada sobre a base de dados SQL Server do ERP devolveu os seguintes dados para o cliente em análise.

### Estrutura dos campos devolvidos

| Campo | Tipo | Descrição |
|---|---|---|
| Cliente | NVARCHAR | Código único do cliente no ERP |
| Nome | NVARCHAR | Designação comercial do cliente |
| LimiteCredito | DECIMAL | Limite de crédito atribuído (€) |
| CondPag | INT | Código interno da condição de pagamento |
| CondPagDescricao | NVARCHAR | Descrição da condição de pagamento |
| PrazoPagamentoDias | INT | Prazo de pagamento em dias definido na ficha |
| SaldoAtualEmDivida | DECIMAL | Saldo total atualmente em aberto (€) |
| NumeroFaturasVencidasNaoPagas | INT | Número de faturas com data de vencimento ultrapassada e ainda não pagas |
| ValorFaturasVencidasNaoPagas | DECIMAL | Valor total das faturas vencidas e não pagas (€) |
| DiasMediosAtrasoPagamento12M | DECIMAL | Média de dias de atraso nos pagamentos dos últimos 12 meses |
| ValorEncomendasAbertas | DECIMAL | Valor total das encomendas ainda não satisfeitas — exposição futura (€) |
| ExposicaoTotalAtual | DECIMAL | Soma do saldo em dívida com o valor de encomendas abertas (€) |
| PercentagemUtilizacaoPlafond | DECIMAL | (ExposicaoTotalAtual / LimiteCredito) × 100 |

### Notas de interpretação
- **PercentagemUtilizacaoPlafond > 100** significa que a exposição total excede o limite de crédito atribuído.
- **PrazoPagamentoDias = 0** indica condição de pronto pagamento — qualquer saldo em aberto é imediatamente relevante.
- **DiasMediosAtrasoPagamento12M** é calculado sobre os pagamentos efetivamente realizados nos últimos 12 meses; não inclui faturas ainda por pagar.
- **ValorEncomendasAbertas** representa compromisso futuro — encomendas aceites mas ainda não faturadas.

### Dados do cliente

{{
  ""Cliente"": ""{Cliente}"",
  ""Nome"": ""{Nome}"",
  ""LimiteCredito"": {LimiteCredito},
  ""CondPag"": {CondPag},
  ""CondPagDescricao"": ""{CondPagDescricao}"",
  ""PrazoPagamentoDias"": {PrazoPagamentoDias},
  ""SaldoAtualEmDivida"": {SaldoAtualEmDivida},
  ""NumeroFaturasVencidasNaoPagas"": {NumeroFaturasVencidasNaoPagas},
  ""ValorFaturasVencidasNaoPagas"": {ValorFaturasVencidasNaoPagas},
  ""DiasMediosAtrasoPagamento12M"": {DiasMediosAtrasoPagamento12M},
  ""ValorEncomendasAbertas"": {ValorEncomendasAbertas},
  ""ExposicaoTotalAtual"": {ExposicaoTotalAtual},
  ""PercentagemUtilizacaoPlafond"": {PercentagemUtilizacaoPlafond}
}}
";

                string txtPrompt = $@"## Tarefa — Diagnóstico de risco de crédito

És um assistente especializado em análise de risco de crédito para empresas B2B.

Com base nos dados fornecidos no contexto sobre o cliente **{Nome}** (cód. {Cliente}), produz um diagnóstico de risco de crédito completo e objetivo.

Responde exclusivamente em **português europeu**. Sê direto e concreto — o utilizador é um gestor financeiro ou comercial sénior que conhece o cliente e precisa de uma análise fundamentada, não de linguagem genérica.

---

### 1. Resumo executivo
2 a 3 frases que sintetizem o estado atual: exposição vs. limite, comportamento de pagamento e risco imediato.

---

### 2. Análise dos indicadores de risco

Para cada indicador abaixo, indica o nível de risco e uma justificação curta (1 frase):

Estes indicadores da análise dos indicadores de risco devem ser apresentados numa tabela.

| Indicador | Valor | Nível | Justificação |
|---|---|---|---|
| Utilização do plafond | {PercentagemUtilizacaoPlafond}% | Baixo/Médio/Crítico | ... |
| Faturas vencidas não pagas | {NumeroFaturasVencidasNaoPagas} faturas / {ValorFaturasVencidasNaoPagas} € | Baixo/Médio/Crítico | ... |
| Dias médios de atraso (12M) | {DiasMediosAtrasoPagamento12M} dias | Baixo/Médio/Crítico | ... |
| Exposição futura (encomendas) | {ValorEncomendasAbertas} € |Baixo/Médio/Crítico | ... |
| Condição de pagamento | {CondPagDescricao} / {PrazoPagamentoDias} dias | Baixo/Médio/Crítico | ... |

Critérios de referência para classificação:
- Utilização plafond: Baixo < 70% · Médio 70-100% · Crítico > 100%
- Faturas vencidas: Baixo 0 · Médio 1-3 · Crítico > 3
- Dias médios atraso: Baixo < 10 dias · Médio 10-30 dias · Crítico > 30 dias
- Exposição futura: contextualiza em relação ao limite de crédito ({LimiteCredito} €)

---

### 3. Score de risco global

Atribui um dos seguintes níveis e justifica em 1 a 2 frases com os fatores determinantes:

> **Baixo** | **Médio** | **Alto** | **Crítico**

---

### 4. Ações recomendadas

Lista de 2 a 4 ações concretas, priorizadas e acionáveis. Para cada ação indica:
- O que fazer
- Porquê (ligado aos dados do cliente)
- Urgência: Imediata / Curto prazo / Monitorizar

Exemplos possíveis (adapta sempre ao perfil real do cliente):
- Suspender envio de encomendas até regularização do saldo vencido
- Contactar cliente para plano de pagamento das faturas em atraso
- Rever e reduzir o limite de crédito para valor mais próximo da exposição real
- Exigir pagamento antecipado nas próximas encomendas
- Manter condições com revisão em 30 dias";

                // Passar como uma nova lista/array que implementa IEnumerable
                IEnumerable<StdBEUserPromptFunctionContext> contexts = new[] {
                        new StdBEUserPromptFunctionContext() {
                            Background = txtContext,
                            Data = resultado
                        }
                };

                return PriEngine.Platform.InterfacePublico.Pulse.UserPromptFunction(contexts, txtPrompt, StdBETipos.EnumSmartActionExecutionType.WithoutCalculations);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
