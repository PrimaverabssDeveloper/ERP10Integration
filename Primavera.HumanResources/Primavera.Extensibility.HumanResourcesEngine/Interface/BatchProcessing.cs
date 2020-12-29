using System.Diagnostics;
using Primavera.Extensibility.BusinessEntities.ExtensibilityService.EventArgs;
using Primavera.Extensibility.HumanResources.Services;
using RhpBE100;

namespace Primavera.ExtensibilitySamples.HumanResourcesEngine
{
    public class BatchProcessing : RhpBSProcessamento
    {
        double valorRemuneracao = 20;
        public override void AntesDeGravar(RhpBEProcessamento clsProcessamento, ExtensibilityEventArgs e)
        {
            clsProcessamento.Remuneracoes.Add(new RhpBEProcRemuneracao
            {
                Remuneracao = "R20",
                Unidades = 1,
                Valor = valorRemuneracao,
                Origem = OrigemDados.origemVBA,
                Moeda = "EUR",
                AnoReferencia = clsProcessamento.NumPeriodoProcessado,
                TipoCalculo = tpCalculo.tpCalcValorFixo,
                ValorIntroducao = valorRemuneracao,
                ValorIliquido = valorRemuneracao,
                ValorIliquidoEfectivo = valorRemuneracao,
                ValorUnitario = valorRemuneracao,
                PeriodoReferencia = clsProcessamento.NumPeriodoProcessado,
                MesFiscalReferencia = clsProcessamento.MesProcessamento,
                MesCalculoIRS = clsProcessamento.MesProcessamento,
                CalculoDiferidoAtivo = clsProcessamento.CalculoDiferidoAtivo,
                Instrumento = clsProcessamento.Instrumento,
                Situacao = clsProcessamento.Situacao,
                TipoVencimento = (int)clsProcessamento.TipoProcessamento,
                IRSDomicilioFiscal = clsProcessamento.IRSDomicilioFiscal,
                RegimeExRes = clsProcessamento.RegimeExRes
            });

            base.AntesDeGravar(clsProcessamento, e);
        }
        public override void DepoisDeGravar(RhpBEProcessamento clsProcessamento, ExtensibilityEventArgs e)
        {
            Debug.Print("DepoisDeGravar");
        }
    }
}
