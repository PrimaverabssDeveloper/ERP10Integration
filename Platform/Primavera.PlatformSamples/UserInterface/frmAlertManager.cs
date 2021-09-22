using StdPlatBE100;
using System;
using System.Windows.Forms;

namespace Primavera.PlatformSamples.UserInterface
{
    public partial class frmAlertManager : Form
    {
        StdBETipos.TipoNotificacao tipoNotif = StdBETipos.TipoNotificacao.TN_Info;

        public frmAlertManager()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbCustom_CheckedChanged(object sender, EventArgs e)
        {
            grbCustom.Enabled = rdbCustom.Checked;
            btShowAlert.Enabled = !rdbCustom.Checked;
        }

        private void rdbInfo_CheckedChanged(object sender, EventArgs e)
        {
            picMessage.Visible = rdbInfo.Checked;
            tipoNotif = StdBETipos.TipoNotificacao.TN_Info;
        }

        private void rdbMessage_CheckedChanged(object sender, EventArgs e)
        {
            picWarning.Visible = rdbMessage.Checked;
            tipoNotif = StdBETipos.TipoNotificacao.TN_Mensagem;
        }

        private void rdbSuccess_CheckedChanged(object sender, EventArgs e)
        {
            picSuccess.Visible = rdbSuccess.Checked;
            tipoNotif = StdBETipos.TipoNotificacao.TN_Sucesso;
        }

        private void rdbError_CheckedChanged(object sender, EventArgs e)
        {
            picError.Visible = rdbError.Checked;
            tipoNotif = StdBETipos.TipoNotificacao.TN_Alerta;
        }

        /// <summary>
        /// Handles the Click event of the btShowAlert control.
        /// The alert is created using a StdBENotificacao.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btShowAlert_Click(object sender, EventArgs e)
        {
            StdBENotificacao notificacao = new StdBENotificacao
            {
                Tipo = tipoNotif,
                Titulo = txtAlertTitle.Text,
                Mensagem = txtAlertDesc.Text
            };

            PriEngine.Platform.AlertNotificationManager.ShowAlert(notificacao, this);

        }

        /// <summary>
        /// Handles the Click event of the btShowCustom control.
        /// The alert is created at runtime by the user.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btShowCustom_Click(object sender, EventArgs e)
        {
            PriEngine.Platform.AlertNotificationManager.ShowCustomAlert(
                txtCustomTitle.Text,
                txtCustomDesc.Text,
                imgImagens.Images[lstImages.SelectedItems[0].ImageIndex],
                this);
        }

    }
}
