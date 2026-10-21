using Primavera.PlatformSamples.Models;
using StdBE100;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static StdBE100.StdBETipos;

namespace Primavera.PlatformSamples.UserInterface
{
    public partial class frmPromptFunctionFiles  : Form
    {
        // Full paths of the confirmed selection
        public List<string> SelectedFiles { get; private set; } = new List<string>();

        public frmPromptFunctionFiles()
        {
            InitializeComponent();

            txtContext.Text = @"O contexto dos dados contém as vendas com a faturação aos clientes agrupadas por artigo com o total das quantidades e valores das vendas faturadas.
A tabela contém as colunas para este contexto:
[Cliente] que indica o nome do cliente;
[Artigo] que representa o nome do artigo;
[QuantidadeTotal] que representa a quantidade total comprada pelo cliente para o artigo;
[TotalLiquido] que indica a faturação total desse artigo ao cliente.";

            txtData.Text = @"SELECT
    Cliente         = CabecDoc.Nome,
    Artigo          = Artigo.Descricao,
    QuantidadeTotal = SUM(LinhasDoc.Quantidade),
    TotalLiquido    = SUM(LinhasDoc.PrecoLiquido - LinhasDoc.ValorLiquidoDesconto)
FROM        CabecDoc        WITH (NOLOCK)
INNER JOIN  DocumentosVenda WITH (NOLOCK) ON CabecDoc.TipoDoc = DocumentosVenda.Documento
INNER JOIN  LinhasDoc       WITH (NOLOCK) ON CabecDoc.Id = LinhasDoc.IdCabecDoc
                                          AND LinhasDoc.TipoLinha NOT IN ('40','41','60','65') -- exclui comentários/descontos em valor
INNER JOIN  CabecDocStatus  WITH (NOLOCK) ON CabecDoc.Id = CabecDocStatus.IdCabecDoc
LEFT JOIN   Artigo          WITH (NOLOCK) ON LinhasDoc.Artigo = Artigo.Artigo
WHERE
    DocumentosVenda.TipoDocumento = 4          -- só documentos faturados (Financeiro)
    AND CabecDocStatus.Anulado = 0             -- exclui documentos anulados
GROUP BY
    CabecDoc.Nome,
    Artigo.Descricao
ORDER BY
    Cliente, Artigo";

            txtPrompt.Text = "Confirma se os valores de faturação do relatório em anexo coincidem com os dados de vendas fornecidos e identifica eventuais divergências.";

            string file = "RelatorioFaturacao.pdf";
            SelectedFiles.Add(file);
            lstFiles.Items.Add(Path.GetFileName(file));
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DataTable queryResult = null;

            if (string.IsNullOrWhiteSpace(txtPrompt.Text))
            {
                PriEngine.Platform.MensagensDialogos.MostraAviso("The 'Response Instructions (Prompt)' field is required.", StdBE100.StdBETipos.IconId.PRI_Exclama);
                txtPrompt.Focus();
                return;
            }

            var previousCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!string.IsNullOrWhiteSpace(txtData.Text))
                {
                    queryResult = PriEngine.Engine.ConsultaDataTable(txtData.Text);
                }

                // ── Build context and prompt strings ─────────────────────────
                List<StdBEUserPromptFunctionContext> contexts = null;

                if ((queryResult != null && queryResult.Rows.Count > 0) || !string.IsNullOrEmpty(txtContext.Text))
                {
                    contexts = new List<StdBEUserPromptFunctionContext>()
                    {
                        new StdBEUserPromptFunctionContext()
                        {
                            Background = txtContext.Text,
                            Data = queryResult
                        }
                    };
                }

                string result = PriEngine.Platform.InterfacePublico.Pulse.UserPromptFunctionFiles(contexts, txtPrompt.Text, SelectedFiles.ToDictionary(f => Path.GetFileName(f), f => File.ReadAllBytes(f)));
                PriEngine.Platform.MensagensDialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "Prompt Function result:", StdBE100.StdBETipos.IconId.PRI_Informativo, result);
            }
            catch (Exception ex)
            {
                PriEngine.Platform.MensagensDialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, ex.Message, StdBE100.StdBETipos.IconId.PRI_Informativo);
            }
            finally
            {
                Cursor.Current = previousCursor;
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Files";
                dlg.Filter = "PDF (*.pdf)|*.pdf|Images (*.jpg;*.png)|*.jpg;*.png|Text (*.txt;*.md;*.json;*.xml;*.csv)|*.txt;*.md;*.json;*.xml;*.csv|Documents (*.doc;*.docx)|*.doc;*.docx|Presentations (*.ppt;*.pptx)|*.ppt;*.pptx|Spreadsheets (*.xls;*.xlsx)|*.xls;*.xlsx";
                dlg.Multiselect = true;
                dlg.RestoreDirectory = true;
                dlg.CheckFileExists = true;
                dlg.CheckPathExists = true;

                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                foreach (var path in dlg.FileNames)
                {
                    if (!SelectedFiles.Contains(path))
                    {
                        SelectedFiles.Add(path);
                        lstFiles.Items.Add(Path.GetFileName(path));
                    }
                }
            }

            UpdateButtons();
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            int idx = lstFiles.SelectedIndex;
            if (idx < 0)
                return;

            SelectedFiles.RemoveAt(idx);
            lstFiles.Items.RemoveAt(idx);
            UpdateButtons();
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            btnRemoveFile.Enabled = lstFiles.SelectedIndex >= 0;
        }
    }
}
