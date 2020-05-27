using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using CblBE100;

namespace Primavera.Accounting.Documents
{
    public partial class FrmInvoice : Form
    {
        public FrmInvoice()
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
            if (PriEngine.Engine.Contabilidade.PlanoContas.Existe((int)txtYear.Value, textAccount.Text))
            {
                string[] row = { textAccount.Text, comboBoxNature.Text, numericValue.Value.ToString(), comboBoxEntityType.Text, textEntity.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            else
            {
                MessageBox.Show("The selected account doesn't exists.");

                textAccount.Clear();
                textAccount.Focus();
            }
        }

        /// <summary>
        /// Close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Saves a new document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSave_Click(object sender, EventArgs e)
        {
            decimal valorLinha = 0;
            string strAvisos = string.Empty;
            
            try
            {
                CblBEDocumento documento = new CblBEDocumento();
                documento.Ano = (int)txtYear.Value;
                documento.Doc = txtTipoDoc.Text;
                documento.NumDoc = -1;
                documento.Diario = txtJournal.Text;
                documento.NumDiario = -1;
                documento.Dia = 1;
                documento.Mes = 1;
                documento.Modulo = "L";
                documento.Moeda = "EUR";

                documento.IdDocOrigem = documento.ID;
                
                int numLote = 0;

                if (listView1.Items.Count > 0)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        decimal.TryParse(item.SubItems[2].Text, out valorLinha);

                        CblBELinhaDocGeral linha = new CblBELinhaDocGeral();

                        linha.TipoLinha = "F";
                        linha.Conta = item.SubItems[0].Text;
                        linha.Natureza = item.SubItems[1].Text;
                        linha.Moeda = documento.Moeda;
                        linha.TipoEntidade = item.SubItems[3].Text;
                        linha.Entidade = item.SubItems[4].Text;

                        linha.Valor = valorLinha;
                        linha.ValorAlt = valorLinha;
                        linha.ValorOrigem = valorLinha;

                        linha.Cambio = 1;
                        linha.CambioMAlt = 1;
                        linha.CambioOrigem = 1;
                        linha.Lote = numLote;

                        documento.LinhasGeral.Insere(linha);
                        numLote++;
                    }
                }
                else
                {
                    MessageBox.Show("There are no accounts.");
                }

                PriEngine.Engine.Contabilidade.Documentos.Actualiza(documento, ref strAvisos);

                if (strAvisos.Length > 0)
                {
                    MessageBox.Show("Error writing document. \n" + strAvisos);
                }
                else
                {
                    MessageBox.Show("Document saved with success.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save document. \n" + ex.Message);
            }
        }

        /// <summary>
        /// Validate document type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtTipoDoc_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Contabilidade.TiposDocumento.Existe(txtTipoDoc.Text) && (txtTipoDoc.Text.Length > 0))
            {
                MessageBox.Show("The document type doesn't exists.");
                txtTipoDoc.Clear();
                txtTipoDoc.Focus();
            }
            else
            {
                txtDocumentDescription.Text = (string)PriEngine.Engine.Contabilidade.TiposDocumento.DaValorAtributo(txtTipoDoc.Text, "Descricao");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtJournal_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Contabilidade.Diarios.Existe(txtJournal.Text) && (txtJournal.Text.Length > 0))
            {
                MessageBox.Show("The selected journal doesn't exists");
                txtJournal.Clear();
                txtJournal.Focus();
            }
            else
            {
                txtJournalDescription.Text = (string)PriEngine.Engine.Contabilidade.Diarios.DaValorAtributo(txtJournal.Text, "Descricao");
            }
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            comboBoxNature.SelectedIndex = 0;
        }
    }
}
