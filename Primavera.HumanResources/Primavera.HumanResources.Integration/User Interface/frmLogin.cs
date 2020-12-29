using System;
using System.Text;
using System.Windows.Forms;

namespace Primavera.Base.Party
{
    public partial class frmLogin : Form
    {

        #region "Demo Events"

        private void CreateInvoice_Click(object sender, EventArgs e)
        {
            FrmEmployee employee = new FrmEmployee();
            employee.ShowDialog();
        }

        private void btnMonthlyChanges_Click(object sender, EventArgs e)
        {
            frmMonthlyChanges MonthlyChanges = new frmMonthlyChanges();
            MonthlyChanges.ShowDialog();
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            frmPayroll Payroll = new frmPayroll();
            Payroll.ShowDialog();
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
                }
                else
                {
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
            public frmLogin()
            {
                InitializeComponent();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                Properties.Settings.Default.Save();
            }



        #endregion

    }
}
