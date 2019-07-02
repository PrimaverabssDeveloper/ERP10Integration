using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Primavera.Platform.ExtensionsUpgrader
{
    public partial class Manager : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        public Manager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the cmdOpenPlatform control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void cmdOpenPlatform_Click(object sender, EventArgs e)
        {
            try
            {
                Engine.OpenPlataform(txtInstance.Text, txtCompany.Text, txtUser.Text, txtPassword.Text, !ckbProfessional.Checked);

                if (Engine.Platform.Inicializada)
                {
                    LogMessage("Plataforma inicializada.");
                    EnableManagerCommands(true);
                    tabMain.SelectedIndex = 1;
                    txtFilePath.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.LogMessage(ex.ToString());
            }
        }

        /// <summary>
        /// Enables the manager commands.
        /// </summary>
        /// <param name="enable">if set to <c>true</c> [enable].</param>
        void EnableManagerCommands(bool enable)
        {
            this.cmdCopy.Enabled = enable;
            this.cmdInsert.Enabled = enable;
            this.cmdOpenfile.Enabled = enable;
            this.cmdOpenPlatform.Enabled = !enable;
        }

        /// <summary>
        /// Logs the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="cleanup">if set to <c>true</c> [cleanup].</param>
        void LogMessage(string message, bool cleanup = false)
        {
            if (cleanup) txtLogger.ResetText();
            txtLogger.Text = $"{DateTime.Now.ToString("HH:mm:ss")}: {message}{Environment.NewLine}{txtLogger.Text}";
        }

        /// <summary>
        /// Handles the Leave event of the txtPrimaveraInstallFolder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void txtPrimaveraInstallFolder_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrimaveraInstallFolder.Text))
            {
                Helper.Installation_Path = txtPrimaveraInstallFolder.Text;
            }
        }

        /// <summary>
        /// Handles the Load event of the Manager control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void Manager_Load(object sender, EventArgs e)
        {
            this.lblPEX.Parent = this.picHeader;
            this.txtPrimaveraInstallFolder.Text = Helper.Installation_Path;
        }

        /// <summary>
        /// Handles the Click event of the cmdOpenfile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmdOpenfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Extensions (*.dll)|*.dll";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    txtFilePath.Text = ofd.FileName;
                    GetFileMetada(txtFilePath.Text);
                }
            }
        }

        /// <summary>
        /// Gets the file metada.
        /// </summary>
        /// <param name="file">The file.</param>
        private void GetFileMetada(string file)
        {
            try
            {
                if (File.Exists(file))
                {
                    var sb = new StringBuilder();
                    var aName = AssemblyName.GetAssemblyName(file);

                    sb.AppendLine(aName.FullName);
                    sb.AppendLine(aName.ProcessorArchitecture.ToString());
                    sb.AppendLine(aName.Version.ToString());
                    sb.AppendLine(aName.HashAlgorithm.ToString());

                    lblMetadata.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                LogMessage(ex.ToString());
            }
        }

        /// <summary>
        /// Handles the KeyUp event of the txtPassword control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.cmdOpenPlatform_Click(sender, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Handles the Click event of the cmdInsert control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmdInsert_Click(object sender, EventArgs e)
        {
            var company = string.Empty;
            if (ckbOnlyCompany.Checked) company = txtCompany.Text;

            try
            {
                lblCopyPath.Text = Engine.Platform.Extensibility.Configuration.InsertExtensionFromFile(txtFilePath.Text, ckbCopyFile.Checked, company);
                LogMessage("Extensão adicionada.");

                if (ckbCopyFile.Checked) LogMessage("Extensão copiada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogMessage(e.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the cmdCopy control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmdCopy_Click(object sender, EventArgs e)
        {
            try
            {
                var dir = Path.GetDirectoryName(lblCopyPath.Text);
                var file = Path.GetFileName(txtFilePath.Text);

                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                var filename = Path.Combine(dir, file);
                if (File.Exists(filename)) File.Delete(filename);

                File.Copy(txtFilePath.Text, filename);
                LogMessage("Extensão copiada com sucesso.");
                tabMain.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogMessage(ex.ToString());
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ckbCopyFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ckbCopyFile_CheckedChanged(object sender, EventArgs e)
        {
            cmdCopy.Enabled = !ckbCopyFile.Checked;
        }
    }
}