using System;
using System.Windows.Forms;
using RhpBE100;
using Primavera.Erp.Sample;

namespace Primavera.HumanResources
{
    public partial class frmSocialSecPlatBase : Form
    {
        public frmSocialSecPlatBase()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                RhpBEFuncionario objfuncionario = PriEngine.Engine.RecursosHumanos.Funcionarios.Edita(txtEmployee.Text);
                if (objfuncionario == null)
                {
                    MessageBox.Show("The Employee doesn't exist.");
                    
                }

                int result = 0;
                string message = "";
                PriEngine.Engine.RecursosHumanos.SegurancaSocial.RegistarVinculoRegimeGeral(txtPassword.Text, objfuncionario, ref result, ref message);
                MessageBox.Show($"Successful communication: \n {result}: {message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show( $"An error occurred while executing the operation: \n {ex.Message}");
            }

        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmployee_Validated(object sender, EventArgs e)
        {
            txtName.Text = PriEngine.Engine.RecursosHumanos.Funcionarios.DaValorAtributo(txtEmployee.Text.ToUpper(), "Nome").ToString();
        }
    }
}
