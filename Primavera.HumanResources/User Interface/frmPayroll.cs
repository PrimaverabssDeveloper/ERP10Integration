using System;
using System.Windows.Forms;
using RhpBE100;
namespace Primavera.Base.Party
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {
            string error = "";
            try
            {
                RhpBEProcessamento Payroll = new RhpBEProcessamento
                {
                    Funcionario = txtEmployeeID.Text.ToUpper(),
                    NumPeriodoProcessado = dtProcDate.Value.Month,
                    DataProcessamento = dtProcDate.Value,
                    DiasProc = 21,
                    TipoProcessamento = (TipoProc)cmbProcType.SelectedIndex,
                    EnglobaIRS = false,
                    Ano = dtProcDate.Value.Year,
                    DataLimAltMensais = dtAbsOvertime.Value
                };

                Payroll.Periodo = PriEngine.Engine.RecursosHumanos.Funcionarios.DaValorAtributo(Payroll.Funcionario, "Periodo").ToString();

                if (PriEngine.Engine.RecursosHumanos.Processamento.ProcessaAuto(Payroll, ref error))
                {
                    if(chkPayslips.Checked)
                    {
                        ProcessPayslips(Payroll);
                    }
                }

                MessageBox.Show("Processing carried out successfully.");

            }
            catch (Exception Ex)
            {
                MessageBox.Show($"An error has ocorred in processing. \n {Ex.Message}" );
            }

        }

        /// <summary>
        /// Process payslip of employee 
        /// </summary>
        /// <param name="payroll"></param>
        private void ProcessPayslips(RhpBEProcessamento payroll)
        {
            RhpBERecibo payslip = null;
            bool openedMap = false;
            string employeeCurrency = "";
            Platform.Collections.PrimaveraOrderedDictionary records = new Platform.Collections.PrimaveraOrderedDictionary();
            string printSession = "";

            try
            {
                string tempTable = PriEngine.Engine.RecursosHumanos.ProcessamentoRecibos.CriaTabAuxiliares("");
                PriEngine.Engine.RecursosHumanos.ProcessamentoRecibos.ProcessarRecibo(txtEmployeeID.Text, payroll.Ano, payroll.MesProcessamento, payroll.NumProcessamento, payroll.TipoCalculoVencimento, payroll.Periodo, true, false, payroll.TotalDeRemuneracoes, payroll.TotalDeDescontos, payroll.TotalLiquido, DateTime.Today, true, false, true, true, true, true, false, ref employeeCurrency, records, "", "", false, false, ref tempTable, false, "RHPR0006", "", ref payslip);
                PriEngine.Engine.RecursosHumanos.ProcessamentoRecibos.CriaReciboPDF(PriEngine.Platform, payslip, "RHPR0006", tempTable, true, ref openedMap, "0", ref printSession);
            }
            catch 
            {
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmployeeID_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                try
                {
                    txtEmployeeID.Text = txtEmployeeID.Text.ToUpper();
                    txtEmployeeName.Text  = PriEngine.Engine.RecursosHumanos.Funcionarios.DaValorAtributo(txtEmployeeID.Text.ToUpper(), "Nome").ToString();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show($"It was not possible to load the entity. \n {Ex.Message}");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
