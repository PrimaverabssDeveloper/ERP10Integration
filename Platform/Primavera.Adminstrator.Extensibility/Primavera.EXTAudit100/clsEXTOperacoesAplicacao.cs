using StdClasses100;

namespace Primavera.EXTAudit100
{
    /// <summary>
    /// Use this class to add your application security options to the ERP. 
    /// The class name must be like cls<AbtAPL>OperacoesAplicacao, where the AbtAPL is application identifier. 
    /// The AbtAPL must be three characters long.
    /// </summary>
    public class clsEXTOperacoesAplicacao : clsAplAudit
    {
        #region private properties

            private string Instancia { get; set; }
            private string Utilizador { get; set; }
            private string PassWord { get; set; }

        #endregion

        #region _clsAplAudit Members
            /// <summary>
            /// Add the where your security options. This options will be available at user profile in the tab Operations.
            /// </summary>
            /// <param name="objParametros"></param>
            /// <returns>A collection of operations.</returns>
            public clsArvoreOperacoes GetArvOperacoes(clsParamOpsAplicacao objParametros)
            {
                clsArvoreOperacoes objOps = new clsArvoreOperacoes();
                clsOperacaoApl objOp;

                objOp = objOps.Add("mnuOptions", "Options", 0, "");
                objOp = objOps.Add("mnuGeneral", "General", 0, "mnuOptions");
                objOp = objOps.Add("mnuNotifications", "Notifications", 0, "mnuOptions");

                return objOps;
                }

            /// <summary>
            /// Add the where your dynamic security options. This options will be available at user profile in the tab Operations per Company.
            /// The source fir this options cam be static or based in a query (ex: The sales documents).
            /// </summary>
            /// <param name="objParametros"></param>
            /// <returns>A collection of operations.</returns>
            public clsPermissoesVar GetPermissoesDinamicas(clsParamOpsAplicacao objParametros)
            {
                    clsPermissoesVar objVars = new clsPermissoesVar();
                    clsPermissaoVar objVar;

                    objVar = objVars.Add("MyDocumet", "MyDocumet", "FAX", "External application invoice.", objParametros.Empresa);
                    objVar.OperacoesPossiveis.Add("CREATE", "Create");
                    objVar.OperacoesPossiveis.Add("CHANGE", "Modify");
                    objVar.OperacoesPossiveis.Add("DELETE", "Delete");
                    objVar.OperacoesPossiveis.Add("VIEW", "View");

                    return objVars;
            }

        #endregion
    }
}