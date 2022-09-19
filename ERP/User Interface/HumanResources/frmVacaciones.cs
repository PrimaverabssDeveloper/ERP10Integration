using System;
using System.Windows.Forms;
using RhpBE100;
using Primavera.Erp.Sample;

namespace Primavera.HumanResources
{
    public partial class frmVacaciones : Form
    {
        public frmVacaciones()
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

                RhpBEFerias ferias = new RhpBEFerias
                {
                    new RhpBEFeria
                    {
                        Ano = dtVacationDay.Value.Year,
                        Funcionario = objfuncionario.Funcionario,
                        DataFeria = dtVacationDay.Value,
                        Duracao = 1,
                        Acerto = 0,
                        TipoMarcacao = 1,
                        EstadoGozo = false
                    }
                };

                string strAlertas = "";
                PriEngine.Engine.RecursosHumanos.Ferias.GravaFeriasFuncionario(objfuncionario.Funcionario, dtVacationDay.Value.Year, ferias, dtVacationDay.Value.Year, false, null, ref strAlertas);
                PriEngine.Engine.RecursosHumanos.Funcionarios.AtualizaSubsidioFerias(objfuncionario.Funcionario, dtVacationDay.Value.Year);

                MessageBox.Show($"Successful Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while executing the operation: \n {ex.Message}");
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
