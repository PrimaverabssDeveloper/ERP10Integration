using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Primavera.PlatformSamples.UserInterface
{
    public partial class frmPromptFunction : Form
    {
        public frmPromptFunction()
        {
            InitializeComponent();

            DateTime _dataInicio = new DateTime(DateTime.Now.Year, 1, 1); ;
            DateTime _dataFim = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);

            string sql = $@"
SELECT TOP 1000
    CL.Nome        AS Cliente,
    A.Descricao    AS Artigo,
    SUM(l.Quantidade) AS QuantidadeTotal,
    SUM(l.PrecUnit * l.Quantidade) AS TotalLiquido,
	YEAR(c.data)   AS Ano,	
	MONTH(c.data)  AS Mes	
FROM CabecDoc c
INNER JOIN LinhasDoc l
    ON l.IdCabecDoc = c.Id
INNER JOIN Artigo A 
    ON A.Artigo = l.Artigo
INNER JOIN Clientes CL 
    ON CL.Cliente = c.Entidade
WHERE 
    c.Data >= '{_dataInicio:yyyy-MM-dd}'
    AND c.Data <= '{_dataFim:yyyy-MM-dd}'
    AND c.TipoDoc IN ('FA', 'FR', 'VD') 
GROUP BY
    CL.Nome,
    A.Descricao,
	YEAR(c.data),
	MONTH(c.data)
ORDER BY
    CL.Nome,
    A.Descricao,
	YEAR(c.data),
	MONTH(c.data);";

            txtContext.Text = @"O contexto dos dados contém as vendas com a faturação aos clientes agrupadas por artigo com o total das quantidades e valores das vendas faturadas. 
A tabela contém as colunas para este contexto: 
[Cliente] que indica o nome do cliente; 
[Artigo] que representa o nome do artigo; 
[QuantidadeTotal] que representa a quantidade total comprada pelo cliente para o artigo; 
[TotalLiquido] que indica a faturação total desse artigo ao cliente.";

            DataTable resultado = PriEngine.Engine.ConsultaDataTable(sql);
            txtData.Text = DataTableToCsv(resultado);

            txtPrompt.Text = "Analisa e coloca 3 insights em pt-PT dos dados de vendas e identifica a faturação dos 5 clientes com maior volume de vendas.";
        }

        public static string DataTableToCsv(DataTable table)
        {
            var sb = new StringBuilder();

            if (table == null || table.Columns.Count == 0)
                return string.Empty;

            // Cabeçalhos
            for (int i = 0; i < table.Columns.Count; i++)
            {
                sb.Append(table.Columns[i].ColumnName);
                if (i < table.Columns.Count - 1)
                    sb.Append(";");
            }
            sb.AppendLine();

            // Linhas
            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    var valor = row[i]?.ToString();

                    // Escapar valores com ;, aspas ou newline
                    if (valor != null && (valor.Contains(";") || valor.Contains("\"") || valor.Contains("\n")))
                    {
                        valor = "\"" + valor.Replace("\"", "\"\"") + "\"";
                    }

                    sb.Append(valor);

                    if (i < table.Columns.Count - 1)
                        sb.Append(";");
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContext.Text))
            {
                PriEngine.Platform.MensagensDialogos.MostraAviso("The 'Data Source Context' field is required.", StdBE100.StdBETipos.IconId.PRI_Exclama);
                txtContext.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtData.Text))
            {
                PriEngine.Platform.MensagensDialogos.MostraAviso("The 'Data' field is required.", StdBE100.StdBETipos.IconId.PRI_Exclama);
                txtData.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrompt.Text))
            {
                PriEngine.Platform.MensagensDialogos.MostraAviso("The 'Response Instructions (Prompt)' field is required.", StdBE100.StdBETipos.IconId.PRI_Exclama);
                txtPrompt.Focus();
                return;
            }

            string result = PriEngine.Platform.InterfacePublico.Pulse.UserPromptFunction(txtContext.Text, txtData.Text, txtPrompt.Text);
            PriEngine.Platform.MensagensDialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "Prompt Function result:", StdBE100.StdBETipos.IconId.PRI_Informativo, result);
        }
    }
}
