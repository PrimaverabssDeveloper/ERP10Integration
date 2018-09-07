using System;
using System.Text;
using System.Windows.Forms;

namespace Primavera.Inventory.Documents
{
    public partial class LoginForm : Form
    {
        #region "Demo Events"

        private void transferButton_Click(object sender, EventArgs e)
        {
            StockTransfersForm stockTransfersForm = new StockTransfersForm();
            stockTransfersForm.Show();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void compositionsBreakdowsButton_Click(object sender, EventArgs e)
        {
            CompositionsBreakdownsForm compositionsBreakdowns = new CompositionsBreakdownsForm();
            compositionsBreakdowns.Show();
        }

        #endregion

        #region "Login Events"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                PriEngine.CreatContext(companyTextBox.Text, userTextBox.Text, passwordTextBox.Text);

                if (PriEngine.EngineStatus)
                {
                    StringBuilder status = new StringBuilder();

                    status.Append("Company: " + PriEngine.Platform.Contexto.Empresa.CodEmp + " | ");
                    status.Append("Company Name: " + PriEngine.Platform.Contexto.Empresa.IDNome + " | ");
                    status.Append("Currency: " + PriEngine.Platform.Contexto.Empresa.MoedaBase);

                    inventoryEditorsPanel.Visible = true;
                    statusLabel.Text = status.ToString();
                }
                else
                {
                    statusLabel.Text = "Cannot acess to primavera. Check your configuration.";
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
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_FormClosed(object sender, FormClosedEventArgs e) => Dispose();


        #endregion
    }
}
