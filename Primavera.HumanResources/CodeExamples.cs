using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primavera.Base.Party
{
    class CodeExamples
    {
        /// <summary>
        /// Processings a specific list of employees.
        /// </summary>
        /// <param name="EmployeesList">The employees list.</param>
        private void ProcessingEmployees(List<string> EmployeesList, int Year, int Month)
        {
            string periodType = PriEngine.Engine.RecursosHumanos.Params.PeriodoPorDefeito;
            RhpBE100.RhpBELinhaPeriodo period = PriEngine.Engine.RecursosHumanos.Periodos.EditaPeriodoEspecifico(periodType, Month, Year);

            string message = "";

            foreach (string employeeNumber in EmployeesList)
            {
               PriEngine.Engine.RecursosHumanos.Processamento.EfectuaProcessamentoAutomatico(RhpBE100.TipoProc.tpVencimento, Year, Month, Month, periodType, period.DiasUteis, period.DataFim, period.DataFim, employeeNumber, ref message);
            }
        }

    }
}
