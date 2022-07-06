using System;
using System.ComponentModel;
using System.Windows.Forms;
using IntBE100;
using Primavera.Erp.Sample;
using static StdPlatBS100.StdBSTipos;

namespace Primavera.Internal.Documents
{
    public partial class frmDocument : Form
    {
        public frmDocument()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if (PriEngine.Engine.Base.Artigos.Existe(txtArtigo.Text))
            {
                // add row to the Listiew
                string[] row = { txtArtigo.Text, txtArmazem.Text, txtQtd.Value.ToString(), txtPreco.Value.ToString() };
                var listViewItem = new ListViewItem(row);
                lvLinhas.Items.Add(listViewItem);
            }
            else
            {
                ShowMessage("The selected item doesn't exist.");

                txtArtigo.Clear();
                txtArtigo.Focus();
            }
        }

        /// <summary>
        /// Close form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        /// <summary>
        /// Creates a new invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSave_Click(object sender, EventArgs e)
        {
            IntBEDocumentoInterno objDocInterno = new IntBEDocumentoInterno()
            {
                Tipodoc = txtTipoDoc.Text,
                Serie = txtSerie.Text,
                Data = DateTime.Today,
                DataVencimento = DateTime.Today
            };
            string strAvisos = string.Empty;

            try
            {
                if (chkDadosRelacionados.Checked)
                    // Set all the entity related information.
                    PriEngine.Engine.Internos.Documentos.PreencheDadosRelacionados(objDocInterno);

                if (lvLinhas.Items.Count > 0)
                {
                    foreach (ListViewItem item in lvLinhas.Items)
                    {
                        IntBELinhasDocumentoInterno linhas = new IntBELinhasDocumentoInterno();

                        string strArtigo = Convert.ToString(item.SubItems[0].Text);
                        string strArmazem = Convert.ToString(item.SubItems[1].Text);
                        double dblQtd = Convert.ToDouble(item.SubItems[2].Text);
                        double dblPreco = Convert.ToDouble(item.SubItems[3].Text);

                        // Add new line to the document and set all the item related information.
                        PriEngine.Engine.Internos.Documentos.AdicionaLinha(objDocInterno, strArtigo, strArmazem, PrecoUnitario: dblPreco, Quantidade: dblQtd);

                        linhas = objDocInterno.Linhas;
                    }
                }
                else ShowMessage("There are no items.");

                // creates the internal document
                PriEngine.Engine.Internos.Documentos.Actualiza(objDocInterno, ref strAvisos);

                if (strAvisos.Length > 0)
                    ShowMessage($"Error writing document.{Environment.NewLine}" + strAvisos);
                else ShowMessage("Document created successfully!", iconId: StdPlatBS100.StdBSTipos.IconId.PRI_Informativo);
            }
            catch (Exception ex)
            {
                ShowMessage("Unable to save document. \n" + ex.Message);
            }
        }

        /// <summary>
        /// Validate document type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtTipoDoc_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Internos.TabInternos.Existe(txtTipoDoc.Text) & (txtTipoDoc.Text.Length > 0))
            {
                ShowMessage("The document type don't exist.");
                txtTipoDoc.Clear();
                txtTipoDoc.Focus();
                txtDescricao.Text = string.Empty;
            }
            else txtDescricao.Text = (string)PriEngine.Engine.Internos.TabInternos.DaValorAtributo(txtTipoDoc.Text, "Descricao");
        }

        /// <summary>
        /// Validate document Series.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSerie_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Series.Existe("N", txtTipoDoc.Text, txtSerie.Text) & (txtSerie.Text.Length > 0))
            {
                ShowMessage("The series is not defined for the selected document type.");
                txtSerie.Clear();
                txtSerie.Focus();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArmazem_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Inventario.Armazens.Existe(txtArmazem.Text) && txtArmazem.Text.Length > 0)
            {
                ShowMessage("The warehouse doesn't exist.");
                txtArmazem.Clear();
                txtArmazem.Focus();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArtigo_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Artigos.Existe(txtArtigo.Text) && txtArtigo.Text.Length > 0)
            {
                ShowMessage("The item doesn't exist.");
                txtArtigo.Clear();
                txtArtigo.Focus();
                txtArtigoDescricao.Text = string.Empty;
            }
            else txtArtigoDescricao.Text = (string)PriEngine.Engine.Base.Artigos.DaValorAtributo(txtArtigo.Text, "Descricao");
        }

        private void ShowMessage(string strMessage, TipoMsg msgType = TipoMsg.PRI_SimplesOk, IconId iconId = IconId.PRI_Exclama)
        {
            PriEngine.Platform.MensagensDialogos.MostraMensagem(msgType, strMessage, iconId);
        }

        private void frmDocument_Load(object sender, EventArgs e)
        {

        }
    }
}
