using Primavera.Platform.Helpers;
using StdPlatBE100;
using System;
using System.IO;
using System.Windows.Forms;
using static StdPlatBE100.StdBETipos;

namespace Primavera.PlatformSamples.UserInterface
{
    public partial class frmAttachments : Form
    {
        EnumTabelaAnexos tabela;

        public frmAttachments()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAttachments_Load(object sender, EventArgs e)
        {
            cbbCategory.SelectedIndex = 0;
        }

        private void btChooseFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFileLocation.Text = ofd.FileName;
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCode.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtFileLocation.Text))
                {
                    PriEngine.Platform.AlertNotificationManager.ShowCustomAlert(this.Text, "All text fields must be filled!", Properties.Resources.Icon_Message, this);
                    return;
                }

                switch (cbbCategory.SelectedIndex)
                {
                    case 1:
                        tabela = EnumTabelaAnexos.anxClientes;
                        break;
                    default:
                        tabela = EnumTabelaAnexos.anxOutrosTerceiros;
                        break;
                }

                StdBEAnexo anexo = new StdBEAnexo
                {
                    IdAnexo = PriEngine.Platform.FuncoesGlobais.CriaGuid(true),
                    Chave = txtCode.Text,
                    Tabela = tabela,
                    Descricao = Path.GetFileNameWithoutExtension(txtFileLocation.Text),
                    Encriptado = ckbEncrypt.Checked,
                    FicheiroOrigem = txtFileLocation.Text,
                    EmModoEdicao = false,
                    Utilizador = PriEngine.Platform.Contexto.Utilizador.Utilizador,
                    Data = DateTime.Now
                };

                PriEngine.Platform.Anexos.Actualiza(anexo);
                lstAttachs.Items.Add(txtFileLocation.Text);
                txtFileLocation.ResetText();

                PriEngine.Platform.AlertNotificationManager.ShowCustomAlert(this.Text, "Attachment added to entity with success.", Properties.Resources.Icon_Success, this);
            }
            catch (Exception ex)
            {
                StdLoggingHandler.FileTraceIgnoredException(ex);
                PriEngine.Platform.AlertNotificationManager.ShowCustomAlert(this.Text, "An error as occurred while adding the attachment to entity!", Properties.Resources.Icon_Alert, this);
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                string desc = string.Empty;
                switch (cbbCategory.SelectedIndex)
                {
                    case 1:
                        desc = PriEngine.Engine.Base.Fornecedores.DaValorAtributo(txtCode.Text, "Nome");
                        break;
                    default:
                        desc = PriEngine.Engine.Base.Clientes.DaValorAtributo(txtCode.Text, "Nome");
                        break;
                }

                if (!string.IsNullOrEmpty(desc))
                {
                    txtDescription.Text = desc;
                    btSave.Enabled = true;
                }
                else
                {
                    txtDescription.ResetText();
                    btSave.Enabled = false;
                }
            }
            else
            {
                txtDescription.ResetText();
                btSave.Enabled = false;
            }
        }
    }
}
