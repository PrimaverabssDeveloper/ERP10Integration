using System;
using System.Windows.Forms;
using Primavera.Erp.Sample;
using Primavera.ERP.Sample.User_Interface.HumanResources;

namespace Primavera.HumanResources
{
    public partial class frmMonthlyChanges : Form
    {
        public frmMonthlyChanges()
        {
            InitializeComponent();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            bool result = HumanResourcesService.CreateAbsence(txtAbsence.Text, dtDate.Value.Date, txtRemarks.Text, txtEmployee.Text.ToUpper(),
                   chkExcludeProc.Checked, chkExcludeStatistics.Checked, (float)nupDuration.Value, out string message);

            MessageBox.Show(message);

            if (result)
            {
                this.Close();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEmployee_Validated(object sender, EventArgs e)
        {
            txtName.Text = PriEngine.Engine.RecursosHumanos.Funcionarios.DaValorAtributo(txtEmployee.Text.ToUpper(), "Nome").ToString();
        }
    }
}
