using Primavera.Erp.Sample;
using RhpBE100;
using System;
using System.Collections.Generic;

namespace Primavera.ERP.Sample.User_Interface.HumanResources
{
    public static class HumanResourcesService
    {
        /// <summary>
        /// Create Income Statement - Declaração de Rendimentos
        /// </summary>
        /// <param name="employeeList">Employee List</param>
        public static void CreateIncomeStatement(List<RhpBEFuncionario> employeeList)
        {
            string printSession = "";
            employeeList.ForEach(p =>
            {
                RhpBEDeclRendimento objDeclRendimento = new RhpBEDeclRendimento
                {
                    TipoEntidade = "F",
                    CodigoEntidade = p.Funcionario,
                    Ano = DateTime.Today.Year - 1,
                    DataDeclaracao = DateTime.Today,
                    Observacoes = "Text Dummy",
                    ImprIdentificarEmpresa = true,
                    ImprInclNRendSujIRS = true,
                    ImprInclQuotSind = true,
                    ImprInclLinhasNulas = true,
                    ImprInclOutrosDesc = true,
                    Relatorio = "OFIDECL",
                    ImprInclNaoCompart = false,
                };

                PriEngine.Engine.RecursosHumanos.ProcessamentoDeclRend.ProcessaDeclaracao(objDeclRendimento, false, false, string.Empty, ref printSession);
            });
        }

        public static bool CreateAbsence(string absence,DateTime date , string remarks, string employee, bool excludeProc, bool excludeStatistics, float duration, out string message)
        {
            try
            {
                RhpBEFalta absenceType = PriEngine.Engine.RecursosHumanos.Faltas.Edita(absence);

                if (absenceType != null)
                {
                    RhpBECadastroFalta absenceRecords = new RhpBECadastroFalta
                    {
                        CalculoFalta = absenceType.CalculoFaltaDias,
                        Horas = absenceType.Horas,
                        DescontaRem = absenceType.DescontaRemuneracoes != 0,
                        Falta = absence,
                        Data = date,
                        Observacoes = remarks,
                        Funcionario = employee,
                        ExcluiProc = excludeProc,
                        ExcluiEstat = excludeStatistics,
                        Tempo = duration,
                        Origem = (byte)OrigemDados.origemVBA
                    };

                    if (PriEngine.Engine.RecursosHumanos.CadastroFaltas.Existe(absenceRecords.Funcionario, absenceRecords.Data, absenceRecords.Falta))
                    {

                        message = $"The absence {absenceRecords.Falta} already exists for Employee { absenceRecords.Funcionario} on day {absenceRecords.Data}.";
                    }
                    else
                    {
                        PriEngine.Engine.RecursosHumanos.CadastroFaltas.Actualiza(absenceRecords);
                        message = "Writing carried out successfully.";
                        return true;
                    }

                }
                else
                    message = "The Absence type does not exist.";
            }
            catch (Exception ex)
            {
                message = $"An error occurred while executing the operation: \n {ex.Message}";
            }

            return false;
        }

    }
}
