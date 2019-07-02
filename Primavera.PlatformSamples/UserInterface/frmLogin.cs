using Primavera.Platform.Helpers;
using Primavera.PlatformSamples.Helpers;
using Primavera.PlatformSamples.UserInterface;
using System;
using System.Text;
using System.Windows.Forms;

namespace Primavera.PlatformSamples
{
    public partial class frmLogin : Form
    {
        #region "Login Events"

        /// <summary>
        /// Handles the Click event of the CmdLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                StdLoggingHandler.FileTraceEnterMethod();
                StdLoggingHandler.FileTrace("Building priengine context");

                PriEngine.CreatContext(txtempresa.Text, txtuser.Text, txtpass.Text, txtInstance.Text);
                StdLoggingHandler.FileTrace("Check priengine Status");

                if (PriEngine.EngineStatus)
                {
                    StringBuilder status = new StringBuilder();

                    status.Append("Company: ").Append(PriEngine.Platform.Contexto.Empresa.CodEmp).Append(" | ");
                    status.Append("Company Name: ").Append(PriEngine.Platform.Contexto.Empresa.IDNome).Append(" | ");
                    status.Append("Currency: ").Append(PriEngine.Platform.Contexto.Empresa.MoedaBase);

                    StdLoggingHandler.FileTrace(status);

                    pnlActions.Visible = true;
                    lblStatus.Text = status.ToString();
                }
                else
                {
                    StdLoggingHandler.FileTrace("ERROR: Cannot access primavera!");
                    lblStatus.Text = "Cannot acess to primavera. Check your configuration.";
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.ShowErrorMessage(ex, "Login", this);
            }
            finally
            {
                StdLoggingHandler.FileTraceExitMethod();
            }
        }

        #endregion

        #region "Form Events"

        /// <summary>
        /// Initializes a new instance of the <see cref="frmLogin"/> class.
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the FormClosed event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.pnlActions.Location = new System.Drawing.Point(233, 12);
        }


        #endregion

        private void btAlerts_Click(object sender, EventArgs e)
        {
            using (frmAlertManager form = new frmAlertManager())
            {
                form.ShowDialog();
            }
        }

        private void btAttachs_Click(object sender, EventArgs e)
        {
            using (frmAttachments form = new frmAttachments())
            {
                form.ShowDialog();
            }
        }

        private void btLogging_Click(object sender, EventArgs e)
        {
            using (frmLogging form = new frmLogging())
            {
                form.ShowDialog();
            }
        }
    }
}
