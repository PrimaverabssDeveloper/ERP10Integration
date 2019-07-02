using StdBE100;
using StdPlatBS100;
using static StdBE100.StdBETipos;

namespace Primavera.Platform.ExtensionsUpgrader
{
    internal static class Engine
    {
        internal static StdPlatBS Platform;

        public static void OpenPlataform(string Instance, string Company, string User, string Password, bool Executive)
        {
            var objAplConf = new StdBSConfApl();
            EnumTipoPlataforma objTipoPlataforma = Executive ? EnumTipoPlataforma.tpEmpresarial : EnumTipoPlataforma.tpProfissional;

            objAplConf.Instancia = Instance;
            objAplConf.AbvtApl = "ERP";
            objAplConf.PwdUtilizador = Password;
            objAplConf.Utilizador = User;
            objAplConf.LicVersaoMinima = "10.00";

            StdBETransaccao objStdTransac = new StdBETransaccao();

            Platform = new StdPlatBS();
            Platform.AbrePlataformaEmpresa(Company, objStdTransac, objAplConf, objTipoPlataforma);
        }
    }
}