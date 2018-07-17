using Primavera.Platform.Collections;
using StdBE100;
using StdClasses100;
using StdPlatBS100;

namespace Primavera.ExtForms100
{
    /// <summary>
    /// This class implements all the application service.
    /// </summary>
    public class clsExtServicos : clsAplServicos
    {
        #region private properties

        private string UserName { get; set; }
        private string PassWord { get; set; }
        private StdPlatBS Plataforma { get; set; }

        #endregion

        #region clsAplServicos Members
        
        /// <summary>
        /// Set the current user.
        /// </summary>
        /// <param name="strUtilizador"></param>
        /// <param name="strPassword"></param>
        public void AtribuiUtilizador(string strUtilizador, string strPassword)
        {
            this.UserName = strUtilizador;
            this.PassWord = strPassword;
        }

        /// <summary>
        /// This is invoked when the user select a service.
        /// </summary>
        /// <param name="intIndex"></param>
        public void Executa(int intIndex)
        {
            switch (intIndex)
            {
                case 1:
                    this.Plataforma.Dialogos.MostraAviso("Create user wizard service.");
                    break;
            }
        }

        /// <summary>
        /// This method is called when the application is loaded.
        /// </summary>
        /// <param name="enuTipoPlataforma"></param>
        /// <param name="strEmpresa"></param>
        /// <param name="strInstalacao"></param>
        /// <param name="objLic"></param>
        public void Inicializa(StdBETipos.EnumTipoPlataforma enuTipoPlataforma, string strEmpresa, string strInstalacao, clsLicenca objLic)
        {
            StdPlatBS plataforma = new StdPlatBS();
            StdBSConfApl objAplConf = new StdBSConfApl();

            objAplConf.Instancia = "Default";
            objAplConf.AbvtApl = "ERP";
            objAplConf.PwdUtilizador = this.PassWord;
            objAplConf.Utilizador = this.UserName;
            objAplConf.LicVersaoMinima = "10.00";

            plataforma.AbrePlataformaEx(enuTipoPlataforma, strInstalacao, objAplConf);

            this.Plataforma = plataforma;
        }

        /// <summary>
        /// The services provided by the application.
        /// </summary>
        /// <param name="objParametros"></param>
        /// <param name="strLista"></param>
        /// <param name="colLoc"></param>
        public void Lista(clsParamAplServicos objParametros, ref string[] strLista, PrimaveraOrderedDictionary colLoc)
        {
            string[] servicos;
            servicos = new string[2];

            servicos[1] = "Create new user wizard.";

            strLista = servicos;
        }

        /// <summary>
        /// Release all the resources.
        /// </summary>
        public void Termina()
        {
            this.Plataforma.FechaPlataformaEx();
        }
        #endregion
    }
}
