using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RhpBE100;
using StdBE100;

namespace Primavera.Base.Party
{
    public partial class FrmEmployee : Form 
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a list of Employees.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtF4_Click(object sender, EventArgs e)
        {
            PriEngine.Platform.Listas.GetF4SQL("Employee", "SELECT Codigo, Nome FROM Funcionarios ORDER BY Codigo ASC", "Codigo", this, txtID);
        }

        /// <summary>
        /// Close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Load the entity data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtID_Validated(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                try
                {
                    RhpBEFuncionario employee = PriEngine.Engine.RecursosHumanos.Funcionarios.Edita(txtID.Text);
                    if (employee != null)
                    {
                        txtID.Text = employee.Funcionario;
                        txtName.Text = employee.Nome;
                        dtHireDate.Value = employee.DataAdmissao;
                        txtSituation.Text = employee.Situacao;
                        txtWorkPolicy.Text = employee.Instrumento;
                        txtWorkLocation.Text = employee.Estabelecimento;
                        txtSocialSec.Text = employee.SegurancaSocial;
                        txtIncomeTax.Text = employee.IRS;
                        txtIncomeType.Text = employee.TipoRendimento;
                        txtVacantions.Text = employee.FormaPagSF;
                        txtChristmas.Text = employee.FormaPagSN;
                        cmbChristAlloMonth.SelectedIndex = employee.MesSubsNatal-1;
                        cmbVacationAlloMonth.SelectedIndex = employee.MesSubsidioFerias-1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show( $"An error occurred while loading the entity: \n {ex.Message}");
                }
            }

        }

        /// <summary>
        /// Create a new employee on the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {
            RhpBEFuncionario employee = new RhpBEFuncionario
            {
                Funcionario = txtID.Text,
                Nome = txtName.Text,
                DataAdmissao = dtHireDate.Value,
                Situacao = txtSituation.Text,
                Instrumento = txtWorkPolicy.Text,
                Estabelecimento = txtWorkLocation.Text,
                SegurancaSocial = txtSocialSec.Text,
                IRS = txtIncomeTax.Text,
                TipoRendimento = txtIncomeType.Text,
                FormaPagSF = txtVacantions.Text,
                FormaPagSN = txtChristmas.Text,
                MesSubsNatal = cmbChristAlloMonth.SelectedIndex + 1,
                MesSubsidioFerias = cmbVacationAlloMonth.SelectedIndex + 1,

                // Check if entity already exist.
                // If exists them set this flag to true to tell the system to perform an update operation.
                EmModoEdicao = PriEngine.Engine.RecursosHumanos.Funcionarios.Existe(txtID.Text)
            };

            try
            {
                // Create payment method with dummy data
                if (!employee.EmModoEdicao)
                {
                    PriEngine.Engine.RecursosHumanos.FuncFormasPagamento.Actualiza(new RhpBEFormaPagamento
                    {
                        ID = Guid.NewGuid().ToString(),
                        Forma = 1,
                        Moeda = PriEngine.Engine.Contexto.MoedaEuro,
                        Entidade = employee.Funcionario,
                        ContaEmpresa = "001",
                        Default = true
                    });
                }

                PriEngine.Engine.RecursosHumanos.Funcionarios.Actualiza(employee);

                // Create payment method with dummy data
                if (!employee.EmModoEdicao)
                {
                    PriEngine.Engine.RecursosHumanos.FuncFormasPagamento.Actualiza(new RhpBEFormaPagamento
                    {
                        ID = Guid.NewGuid().ToString(),
                        Forma = 1,
                        Moeda = PriEngine.Platform.Contexto.Empresa.MoedaEuro,
                        Entidade = employee.Funcionario,
                        ContaEmpresa = "001",
                        Default = true
                    });

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Unable to save employee. \n {Ex.Message}");
            }

            this.Close();
        }

    }
}
