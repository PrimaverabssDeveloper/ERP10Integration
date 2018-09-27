using System;
using System.Windows.Forms;
using RhpBE100;

namespace Primavera.Base.Party
{
    public partial class frmMonthlyChanges : Form
    {
        public frmMonthlyChanges()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                RhpBEFalta absenceType = PriEngine.Engine.RecursosHumanos.Faltas.Edita(txtAbsence.Text);

                if (absenceType != null)
                {
                    RhpBECadastroFalta absenceRecords = new RhpBECadastroFalta
                    {
                        CalculoFalta = absenceType.CalculoFaltaDias,
                        Horas = absenceType.Horas,
                        DescontaRem = absenceType.DescontaRemuneracoes != 0,
                        Falta = txtAbsence.Text.ToUpper(),
                        Data = dtDate.Value.Date,
                        Observacoes = txtRemarks.Text,
                        Funcionario = txtEmployee.Text.ToUpper(),
                        ExcluiProc = chkExcludeProc.Checked,
                        ExcluiEstat = chkExcludeStatistics.Checked,
                        Tempo = (float)nupDuration.Value,
                        Origem = (byte)OrigemDados.origemVBA
                    };

                    if (PriEngine.Engine.RecursosHumanos.CadastroFaltas.Existe(absenceRecords.Funcionario, absenceRecords.Data, absenceRecords.Falta))
                    {
                        MessageBox.Show($"The absence {absenceRecords.Falta} already exists for Employee { absenceRecords.Funcionario} on day {absenceRecords.Data}.");
                    }
                    else
                    {
                        PriEngine.Engine.RecursosHumanos.CadastroFaltas.Actualiza(absenceRecords);
                        MessageBox.Show("Writing carried out successfully.");
                        this.Close();
                    }

                }
                else
                    MessageBox.Show("The Absence type does not exist.");
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
