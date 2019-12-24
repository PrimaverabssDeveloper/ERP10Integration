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
        #region private properties

        private StdPlatBS100.StdBSNavegador Navegador = null;
        public StdPlatBS100.StdBSLista Lista { get; set; } = null;

        #endregion

        #region constructor

        public FrmInvoice()
        {
            InitializeComponent();

            Navegador = PriEngine.Platform.Navegador;
            Navegador.AbreLista += new StdPlatBS100.StdBSNavegador.AbreListaHandler(Navegador_AbreLista);
        }

        #endregion

        #region controls events

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
                    txtNome.Text = campos[0].Valor.ToString();
                    txtNif.Text = campos[1].Valor.ToString();
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

        #endregion

        #region F4 Events

        private void F4TipoDocumento_Click(object sender, EventArgs e)
        {
            PriEngine.Platform.Listas.TrataF4(
                ConstantesPrimavera100.Categorias.TabDocVND, 
                "Documento", 
                this, 
                txtTipoDoc,
                ConstantesPrimavera100.Audit.TAB_DOC_VND);
        }

        private void F4Cliente_Click(object sender, EventArgs e)
        {
            PriEngine.Platform.Listas.TrataF4(
                ConstantesPrimavera100.Categorias.Cliente,
                "Cliente",
                this,
                txtEntidade,
                ConstantesPrimavera100.Audit.TAB_CLIENTES);
        }

        private void txtArtigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F4))
            {
                PriEngine.Platform.Listas.TrataF4(
                ConstantesPrimavera100.Categorias.Artigo,
                "Artigo",
                this,
                txtArtigo,
                ConstantesPrimavera100.Audit.TAB_ARTIGOS);
            }
        }

        #endregion

        #region F4 methods

        public void Navegador_AbreLista(StdPlatBE100.StdBEF4 ObjF4, StdBSSql100.StdBSOSQL SqlBSO, StdBESql100.StdBESqlQuery Query, StdBE100.StdBECampos Filtro)
        {
            // Utilizador tem permissões sobre a categoria?
            if ((PriEngine.Platform.Categorias.TestaPermissaoLista(Query.Categoria, Query.Query, Query.Utilizador, Query.Sistema, StdPlatBE100.StdBETipos.TipoPermissaoListas.tplstConsultar)))
            {
                TrataNavegadorAbreLista(ObjF4, SqlBSO, Query, Filtro); ;
            }
        }

        /// <summary>
        /// Do not chabge this code, just use as is.
        /// </summary>
        /// <param name="ObjF4"></param>
        /// <param name="SqlBSO"></param>
        /// <param name="Query"></param>
        /// <param name="Filtro"></param>
        private void TrataNavegadorAbreLista(StdPlatBE100.StdBEF4 ObjF4, StdBSSql100.StdBSOSQL SqlBSO, StdBESql100.StdBESqlQuery Query, StdBE100.StdBECampos Filtro)
        {
            StdPlatBS100.frmLista fFormLista = null;

            var bF4 = false;
            var bModal = false;

            if (ObjF4 != null)
            {
                bF4 = true;
                bModal = ObjF4.Modal;
            }

            if (bF4)
            {
                if (bModal || fFormLista == null)
                {
                    fFormLista = PriEngine.Platform.Dialogos.DaDialogoListas();
                    PriEngine.Platform.Menus.ClasseBase = this;
                    fFormLista.F4 = (ObjF4 != null);
                    fFormLista.F4Ctrl = ObjF4;
                    fFormLista.Inicializa(this, Query, Filtro);

                    fFormLista.ShowDialog();

                    if (!ObjF4.FormF4.TopLevel)
                    {
                        ObjF4.FormF4.Parent.FindForm()?.BringToFront();
                    }
                    else
                    {
                        ObjF4.FormF4.BringToFront();
                    }
                }
                else
                {
                    fFormLista.BringToFront();
                }
            }
            else
            {
                fFormLista.BringToFront();
            }
        }

        #endregion
    }
}
