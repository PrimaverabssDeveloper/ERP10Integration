using System;
using System.Text;
using System.Windows.Forms;

namespace Primavera.ReservasStock
{
    public partial class Login : Form
    {

        #region "Demo Events"

        private void CreateInvoice_Click(object sender, EventArgs e)
        {
            FrmReservaDestino frmReservaDestino = new FrmReservaDestino();
            frmReservaDestino.Show();
        }

        private void cmdCreateReversal_Click(object sender, EventArgs e)
        {
            FrmReservaOrigem frmReservaOrigem = new FrmReservaOrigem();
            frmReservaOrigem.Show();
        }

        #endregion

        #region "Login Events"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                PriEngine.CreatContext(txtempresa.Text, txtuser.Text, txtpass.Text);

                if (PriEngine.EngineStatus)
                {
                    StringBuilder status = new StringBuilder();

                    status.Append("Company: " + PriEngine.Platform.Contexto.Empresa.CodEmp + " | ");
                    status.Append("Company Name: " + PriEngine.Platform.Contexto.Empresa.IDNome + " | ");
                    status.Append("Currency: " + PriEngine.Platform.Contexto.Empresa.MoedaBase);

                    panel1.Visible = true;
                    lblStatus.Text = status.ToString();
                }
                else
                {
                    lblStatus.Text = "Cannot acess to primavera. Check your configuration.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region "Form Events"

        /// <summary>
        /// 
        /// </summary>
        public Login()
        {
            InitializeComponent();
            priMemorizaLayout1.Modulo = ConstantesPrimavera100.Modulos.Vendas;
            priMemorizaLayout1.ChaveJanela = this.Name;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        #endregion
    }
}
