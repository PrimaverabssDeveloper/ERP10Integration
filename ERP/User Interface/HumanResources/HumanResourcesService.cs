using Primavera.Erp.Sample;
using RhpBE100;
using System;

namespace Primavera.ERP.Sample.User_Interface.HumanResources
{
    public static class HumanResourcesService
    {
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

        public static bool soma()
        {
            return true;
        }
    }
}
