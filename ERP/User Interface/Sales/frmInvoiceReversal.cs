using System;
using System.ComponentModel;
using System.Windows.Forms;
using static StdPlatBS100.StdBSTipos;
using Primavera.Erp.Sample;

namespace Primavera.Sales.Invoice
{
    public partial class frmInvoiceReversal : Form
    {
        /// <summary>
        /// In this example we create a total reversal of the original document
        /// </summary>
        public frmInvoiceReversal()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void txtTipoDoc_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Vendas.TabVendas.Existe(txtTipoDoc.Text) & (txtTipoDoc.Text.Length > 0))
            {
                ShowMessage("The document type don't exist.");
                txtTipoDoc.Clear();
                txtTipoDoc.Focus();
            }
            else txtDescricao.Text = (string)PriEngine.Engine.Vendas.TabVendas.DaValorAtributo(txtTipoDoc.Text, "Descricao");
        }

        private void txtSerie_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Series.Existe("V", txtTipoDoc.Text, txtSerie.Text) & (txtSerie.Text.Length > 0))
            {
                ShowMessage("The series is not defined for the selected document type.");
                txtSerie.Clear();
                txtSerie.Focus();
            }
        }

        private void txtNumDoc_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // check if the original document exists 
                if (PriEngine.Engine.Vendas.Documentos.Existe("000", txtTipoDoc.Text, txtSerie.Text, (int)txtNumDoc.Value))
                {
                    // get the reversal document properties we need
                    StdBE100.StdBECampos objFields = PriEngine.Engine.Vendas.TabVendas.DaValorAtributos(txtTipoDoc.Text, "PermiteEstorno", "DocumentoEstorno", "SerieDocEstorno");
                    StdBE100.StdBECampos objFieldsEntity = PriEngine.Engine.Vendas.Documentos.DaValorAtributos("000", txtTipoDoc.Text, txtSerie.Text, (int)txtNumDoc.Value, "Entidade", "Nome");

                    if (objFields != null)
                    {
                        // if it doesn't allow reversals...
                        if (!(bool)objFields["PermiteEstorno"].Valor)
                            ShowMessage($"Document {txtTipoDoc.Text} doesn't allow reversals.");
                        else
                        {
                            // set the reversal document properties in the screen
                            txtRevTipoDoc.Text = (string)objFields["DocumentoEstorno"].Valor;
                            txtRevTipoDocDescricao.Text = (string)PriEngine.Engine.Vendas.TabVendas.DaValorAtributo(txtRevTipoDoc.Text, "Descricao");
                            txtRevSerie.Text = (string)objFields["SerieDocEstorno"].Valor;

                            if (objFieldsEntity != null)
                            {
                                txtEntidade.Text = (string)objFieldsEntity["Entidade"].Valor;
                                txtNome.Text = (string)objFieldsEntity["Nome"].Valor;
                            }

                            // get the reversal document type next number
                            int intLastNumber = PriEngine.Engine.Base.Series.ProximoNumero("V", txtRevTipoDoc.Text, txtRevSerie.Text);

                            txtRevNumDoc.Value = intLastNumber;

                            // set the date for today
                            txtRevDate.Value = DateTime.Today;

                            return;
                        }
                    }
                    else ShowMessage("Can't retrieve document type information.");
                }
                else ShowMessage($"Document {txtTipoDoc.Text} {txtSerie.Text}/{txtNumDoc.Value} doesn't exist.");

                ClearControls(blnOriginalDoc: false);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, iconId: IconId.PRI_Critico);
            }
        }

        private void txtRevMotivo_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.MotivosEstorno.Existe(txtRevMotivo.Text) & (txtRevMotivo.Text.Length > 0))
            {
                ShowMessage("The reversal cause doesn't exist.");
                txtRevMotivo.Clear();
                txtRevMotivo.Focus();
            }
            else txtRevMotivoDescricao.Text = (string)PriEngine.Engine.Base.MotivosEstorno.DaValorAtributo(txtRevMotivo.Text, "Descricao");
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                // get the original document date for later comparison
                DateTime dtOrigDocDate = PriEngine.Platform.Utils.FData(PriEngine.Engine.Vendas.Documentos.DaValorAtributo("000", txtTipoDoc.Text, txtSerie.Text, (int)txtNumDoc.Value, "Data"));

                if (txtRevMotivo.Text.Trim().Length > 0)
                {
                    if (txtRevDate.Value >= dtOrigDocDate)
                    {
                        // if the reversal cause and date are correctly set,
                        // get the orginal document ID
                        string strIdOrigDoc = (string)PriEngine.Engine.Vendas.Documentos.DaValorAtributo("000", txtTipoDoc.Text, txtSerie.Text, (int)txtNumDoc.Value, "Id");
                        DateTime dtRevDate = txtRevDate.Value;
                        DateTime dtToday = DateTime.Today;
                        VndBE100.VndBEDocumentoVenda objRevDoc = null;

                        // reverse the original document by calling the "EstornaDocumentoVenda" method in the "Vendas" engine
                        PriEngine.Engine.Vendas.Documentos.EstornaDocumentoVenda(strIdOrigDoc, txtRevMotivo.Text, txtObservacoes.Text,
                            ref dtRevDate, ref dtToday, ref objRevDoc, true);

                        if (objRevDoc != null)
                        {
                            ShowMessage($"The reversal document {txtRevTipoDoc.Text} {txtRevSerie.Text}/{objRevDoc.NumDoc} was created successfully!",
                                iconId: IconId.PRI_Informativo);

                            ClearControls(true);
                        }
                        else ShowMessage("The reversal document was not successfully created.");
                    }
                    else ShowMessage("The reversal date needs to be equal ou higher than the original document one.");
                }
                else ShowMessage("The reversal cause is invalid.");
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, iconId: IconId.PRI_Critico);
            }
        }

        private void frmInvoiceReversal_Load(object sender, EventArgs e)
        {
            // set the focus to the first control
            ActiveControl = txtTipoDoc;
        }

        /// <summary>
        /// Clear the controls in the screen
        /// </summary>
        /// <param name="blnBoth">Both the document groups?</param>
        /// <param name="blnOriginalDoc">Only the original document group?</param>
        private void ClearControls(bool blnBoth = false, bool blnOriginalDoc = true)
        {
            // only the original document group
            if (blnOriginalDoc || blnBoth)
            {
                txtTipoDoc.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtSerie.Text = string.Empty;
                txtNumDoc.Value = 0;
                txtEntidade.Text = string.Empty;
                txtNome.Text = string.Empty;
            }

            // only the reversal document group
            if (!blnOriginalDoc || blnBoth)
            {
                txtRevTipoDoc.Text = string.Empty;
                txtRevTipoDocDescricao.Text = string.Empty;
                txtRevSerie.Text = string.Empty;
                txtRevNumDoc.Value = 0;
                txtRevMotivo.Text = string.Empty;
                txtRevMotivoDescricao.Text = string.Empty;
                txtRevDate.Value = DateTime.Today;
                txtObservacoes.Text = string.Empty;
            }
        }

        private void ShowMessage(string strMessage, TipoMsg msgType = TipoMsg.PRI_SimplesOk, IconId iconId = IconId.PRI_Exclama)
        {
            PriEngine.Platform.MensagensDialogos.MostraMensagem(msgType, strMessage, iconId);
        }
    }
}
