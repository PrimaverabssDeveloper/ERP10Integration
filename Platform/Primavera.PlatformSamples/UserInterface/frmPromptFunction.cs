using System;
using System.Text;
using System.Windows.Forms;

namespace Primavera.PlatformSamples.UserInterface
{
    public partial class frmPromptFunction : Form
    {
        public frmPromptFunction()
        {
            InitializeComponent();

            txtContext.Text = "Items list:";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Item;Description;Price");
            sb.AppendLine("A0001;Item A0001;55.87");
            sb.AppendLine("A0002;Item A0002;45.32");
            sb.AppendLine("A0003;Item A0003;78.90");
            sb.AppendLine("A0004;Item A0004;12.34");
            sb.AppendLine("A0005;Item A0005;67.89");
            sb.AppendLine("A0006;Item A0006;23.45");
            sb.AppendLine("A0007;Item A0007;89.01");
            txtData.Text = sb.ToString();

            txtPrompt.Text = "Sort from most expensive to least expensive.";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContext.Text))
            {
                PriEngine.Platform.MensagensDialogos.MostraAviso("The 'Data Source Context' field is required.", StdBE100.StdBETipos.IconId.PRI_Exclama);
                txtContext.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtData.Text))
            {
                PriEngine.Platform.MensagensDialogos.MostraAviso("The 'Data' field is required.", StdBE100.StdBETipos.IconId.PRI_Exclama);
                txtData.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrompt.Text))
            {
                PriEngine.Platform.MensagensDialogos.MostraAviso("The 'Response Instructions (Prompt)' field is required.", StdBE100.StdBETipos.IconId.PRI_Exclama);
                txtPrompt.Focus();
                return;
            }

            string result = PriEngine.Platform.InterfacePublico.Pulse.UserPromptFunction(txtContext.Text, txtData.Text, txtPrompt.Text);
            PriEngine.Platform.MensagensDialogos.MostraMensagem(StdPlatBS100.StdBSTipos.TipoMsg.PRI_SimplesOk, "Prompt Function result:", StdBE100.StdBETipos.IconId.PRI_Informativo, result);
        }
    }
}
