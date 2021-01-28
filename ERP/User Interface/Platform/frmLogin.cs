using System;
using System.Windows.Forms;

namespace Primavera.Erp.Sample
{
    public partial class Login : Form
    {
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
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Cannot acess to primavera. Check your configuration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
