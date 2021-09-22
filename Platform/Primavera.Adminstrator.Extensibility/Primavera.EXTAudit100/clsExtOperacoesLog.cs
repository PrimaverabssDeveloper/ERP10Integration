using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StdClasses100;

namespace Primavera.EXTAudit100
{
    /// <summary>
    /// Use this class to add events about your application activity to the ERP log system
    /// The class name must be like cls<AbtAPL>OperacoesLog, where the AbtAPL is application identifier. 
    /// The AbtAPL must be three characters long.
    /// </summary>
    public class clsExtOperacoesLog : clsAplOperacoesLog
    {
        #region _clsAplOperacoesLog Members
            public clsOperacoesLog GetDaOperacoesLog(clsParamOpsLog objParametros)
            {
                clsOperacoesLog opLog;

                return null;
            }
        #endregion
    }
}
