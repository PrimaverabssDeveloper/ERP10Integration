using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StdBE100;
using StdClasses100;


namespace Primavera.ExtForms100
{
    public class clsExtLoginsAssociados:clsAplLoginsAssociados
    {
        /// <summary>
        /// Show additional login information. 
        /// Some providers require more information than the user & password. Aouth2 requires client Id and client credential.
        /// </summary>
        /// <param name="objParams"></param>
        /// <param name="objLoginAssociado"></param>
        /// <returns></returns>
        public bool EditaInfoAdicional(clsParamAplLoginsEdita objParams, dynamic objLoginAssociado)
        {
            frmLogin objfrm = new frmLogin();

            objfrm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            objfrm.ShowDialog();
            objLoginAssociado.Tag = "Insert where additional login information provided by your application. Ex: Token";
            objfrm.Close();

            return true;
        }

        /// <summary>
        /// Build the login map.
        /// </summary>
        /// <param name="objParams"></param>
        /// <returns></returns>
        public StdBETiposLoginAssociado ListaTipos(clsParamAplLoginsLista objParams)
        {
            StdBETiposLoginAssociado objRes = new StdBETiposLoginAssociado();

            dynamic objTipo = objRes;

            objTipo.InsereNovo("Ext", "Login_External_Apl", "External Application", true, false);

            return objRes;
        }
    }
}
