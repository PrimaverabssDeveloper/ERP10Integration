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

                    if(chkSocialSecurity.Checked)
                    {
                        ProcessSocialSecurity(Payroll.Ano, Payroll.MesProcessamento, Payroll.Funcionario);
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
            PriEngine.Engine.RecursosHumanos.Recibos.IniciaProcessamentoRecibos();
            PriEngine.Engine.RecursosHumanos.Recibos.ProcessaRecibos(new RhpBERecibo
            {
                CodigoFuncionario = txtEmployeeID.Text,
                Ano = payroll.Ano,
                NumPeriodo = payroll.NumPeriodoProcessado,
                CodigoPeriodo = payroll.Periodo,
                ImprInclFaltas = true,
                ImprAglomearar = true,
                Relatorio = "RHPR0006",
                Moeda = "EUR"
            }, false);
            PriEngine.Engine.RecursosHumanos.Recibos.TerminaProcessamentoRecibos();
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

        /// <summary>
        /// Processes the employee social security.
        /// </summary>
        public void ProcessSocialSecurity(int Ano, int Mes, string Funcionario)
        {
            RhpBEDadosSegSocial objDadosSS = new RhpBEDadosSegSocial
            {
                NomeEmpresa = PriEngine.Engine.Contexto.CodEmp,
                ArredondamentoMBase = PriEngine.Engine.Contexto.MBaseDecArredonda,
                MoedaBase = PriEngine.Engine.Contexto.MoedaBase,
                MoedaEur = PriEngine.Engine.Contexto.MoedaEuro,
                MoedaTrab = PriEngine.Engine.Contexto.MoedaBase,
                NumSegSocialEmp = PriEngine.Engine.Contexto.OINumSegSocial,
                ArredondaMultiplosMeioDia = true,
                AnoEmpresa = Ano,
                MesAProcessar = Mes,
                FormatoMagnetico = "RC4008",
                FiltroFuncionario = Funcionario
            };

            if (!PriEngine.Engine.RecursosHumanos.ProcessamentoSegSocial.ProcessarAuto(objDadosSS, out string Mensagem))
            {
                MessageBox.Show($"An error has ocorred in processing Social Security. \n {Mensagem}");
            }
        }
    }
}
