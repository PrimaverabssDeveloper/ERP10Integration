using StdBE100;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using VndBE100;
using static BasBE100.BasBETiposGcp;

namespace Primavera.Sales.Invoice
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
            if (PriEngine.Engine.Base.Artigos.Existe(txtArtigo.Text))
            {
                string[] row = { txtArtigo.Text, txtQtd.Value.ToString() };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            else
            {
                MessageBox.Show("The selected item don't exist.");

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
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// Creates a new invoice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdSave_Click(object sender, EventArgs e)
        {
            VndBEDocumentoVenda invoice = new VndBEDocumentoVenda();
            string strAvisos = string.Empty;

            invoice.Tipodoc = txtTipoDoc.Text;
            invoice.Entidade = txtEntidade.Text;
            invoice.TipoEntidade = "C";
            invoice.Serie = txtSerie.Text;

            // To save the document as draft set this flag to true
            //invoice.Rascunho = true ;

            try
            {
                if (checkBox1.Checked)
                {
                    // Set all the entity related information.
                    PriEngine.Engine.Vendas.Documentos.PreencheDadosRelacionados(invoice);
                }

                if (listView1.Items.Count > 0)
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        VndBELinhasDocumentoVenda linhas = new VndBELinhasDocumentoVenda();
     
                        double qtd = Convert.ToDouble(item.SubItems[1].Text);

                        // Add new line to the invoice and set all the item related information.
                        PriEngine.Engine.Vendas.Documentos.AdicionaLinha(invoice, item.SubItems[0].Text, ref qtd);

                        linhas = invoice.Linhas;
                        linhas.GetEdita(1).Desconto1 = 10;

                        // User custom flied
                        StdBECampo campo = new StdBECampo();

                        campo.Nome = "CDU_LinVar1";
                        campo.Valor = 12;
                        campo.Tipo = StdBETipos.EnumTipoCampo.tcText;

                        linhas.GetEdita(1).CamposUtil.Insere(campo);

                    }

                    if (txtobs.Text.Length > 0)
                    {
                        PriEngine.Engine.Vendas.Documentos.AdicionaLinhaEspecial(invoice, vdTipoLinhaEspecial.vdLinha_Comentario, 0, txtobs.Text);
                    }
                }
                else
                {
                    MessageBox.Show("There are no items.");
                }

                PriEngine.Engine.Vendas.Documentos.CalculaValoresTotais(invoice);

                // Save the document as draft.
                // PriEngine.Engine.Comercial.Vendas.ActualizaRascunho(invoice, ref strAvisos);

                PriEngine.Engine.Vendas.Documentos.Actualiza(invoice, ref strAvisos);

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
            finally
            {

            }
        }

        /// <summary>
        /// Validate document type.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtTipoDoc_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Vendas.TabVendas.Existe(txtTipoDoc.Text) & (txtTipoDoc.Text.Length > 0))
            {
                MessageBox.Show("The document type don't exist.");
                txtTipoDoc.Clear();
                txtTipoDoc.Focus();
            }
            else
            {
                txtDescricao.Text = (string)PriEngine.Engine.Vendas.TabVendas.DaValorAtributo(txtTipoDoc.Text, "Descricao");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtEntidade_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Clientes.Existe(txtEntidade.Text) & (txtEntidade.Text.Length > 0))
            {
                MessageBox.Show("The selected entity don't exist");
                txtEntidade.Clear();
                txtEntidade.Focus();
            }
            else
            {
                object[] camposBD = new object[2] { "Nome", "NumContrib" };

                StdBECampos campos = PriEngine.Engine.Base.Clientes.DaValorAtributos(txtEntidade.Text, camposBD);

                if (campos != null)
                {
                    txtNome.Text = campos[1].Valor;
                    txtNif.Text = campos[2].Valor;
                }
            }
        }

        /// <summary>
        /// Validate document Series.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSerie_Validating(object sender, CancelEventArgs e)
        {
            if (!PriEngine.Engine.Base.Series.Existe("V", txtTipoDoc.Text, txtSerie.Text) & (txtSerie.Text.Length > 0))
            {
                MessageBox.Show("The series is not defined for the selected document type.");
                txtSerie.Clear();
                txtSerie.Focus();
            }
        }
    }
}
