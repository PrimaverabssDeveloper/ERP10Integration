
using Primavera.Platform.Collections;
using StdBE100;
using StdClasses100;

namespace Primavera.ExtForms100
{
    /// <summary>
    /// This class implements all the application parameters.
    /// </summary>
    public class clsExtParametrizacoes : clsAplParametrizacoes
    {
        # region private properties

        private string Utilizador { get; set; }
        private string PassWord { get; set; }

        #endregion

        #region clsAplParametrizacoes Members

        /// <summary>
        /// Set the current user.
        /// </summary>
        /// <param name="strUtilizador"></param>
        /// <param name="strPassword"></param>
        public void AtribuiUtilizador(string strUtilizador, string strPassword)
        {
            this.Utilizador = strUtilizador;
            this.PassWord = strPassword;
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
        }

        /// <summary>
        /// The parameters provided by the application.
        /// </summary>
        /// <param name="objParametros"></param>
        /// <param name="strLista"></param>
        /// <param name="colLoc"></param>
        public void Lista(clsParamAplParams objParametros, ref string[] strLista, PrimaveraOrderedDictionary colLoc)
        {
            string[] Parametros;

            Parametros = new string[2];

            Parametros[1] = "General Parameters";
            strLista = Parametros;
        }

        /// <summary>
        /// Must be set to true.
        /// </summary>
        public bool ModuloDisponivelLocalizacao(StdBETipos.EnumLocalizacaoSede enuLocSede)
        {
            return true;
        }

        /// <summary>
        /// This is invoked when the user select a form.
        /// </summary>
        /// <param name="intIndex"></param>
        /// <param name="intModoOperacao"></param>
        /// <param name="objOwnerForm"></param>
        public void Mostra(int intIndex, int intModoOperacao, dynamic objOwnerForm)
        {
            switch (intIndex)
            {
                case 1:
                    frmGerais frmgerais = new frmGerais();
                    frmgerais.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                    frmgerais.ShowDialog();
                    break;
            }

            // Activate the parent interface.
            var method = objOwnerForm.GetType().GetMethod("ActivaInterface");
            method.Invoke(objOwnerForm, new object[] { true });
        }

        /// <summary>
        /// Release all the resources.
        /// </summary>
        public void Termina()
        {
        }

        public void TiposExercicioSuportados(StdBETipos.EnumTipoPlataforma enuTipoPlataforma, ref StdBETipos.EnumTipoExercicio[] enuTiposExercicio)
        {
        }
        #endregion
    }
}
