using ErpBS100;
using Primavera.Platform.Helpers;
using StdBE100;
using StdPlatBS100;
using System;
using static StdBE100.StdBETipos;

namespace Primavera.PlatformSamples
{
    sealed class PriEngine: DisposableBase
    {
        #region  Singleton pattern 

        // .NET guarantees thread safety for static initialization
        private static readonly PriEngine engineInstance = new PriEngine();

        /// <summary>
        /// Private constructor
        /// </summary>
        private PriEngine()
        {   
        }

        /// <summary>
        /// Creats the context.
        /// </summary>
        /// <param name="Company">The company.</param>
        /// <param name="User">The user.</param>
        /// <param name="Password">The password.</param>
        /// <param name="Instance">ERP instance.</param>
        /// <returns></returns>
        public static PriEngine CreatContext(string Company, string User, string Password, string Instance)
        {
            try
            {
                StdLoggingHandler.FileTraceEnterMethod();
                StdLoggingHandler.FileTrace("Creating objects");

                StdBSConfApl objAplConf = new StdBSConfApl();
                StdPlatBS Plataforma = new StdPlatBS();
                ErpBS MotorLE = new ErpBS();

                StdLoggingHandler.FileTrace("Setting configuration");
                EnumTipoPlataforma objTipoPlataforma = EnumTipoPlataforma.tpEmpresarial;

                objAplConf.Instancia = Instance;
                objAplConf.AbvtApl = "ERP";
                objAplConf.PwdUtilizador = Password;
                objAplConf.Utilizador = User;
                objAplConf.LicVersaoMinima = "10.00";

                StdLoggingHandler.FileTrace("Setting transaccao");
                StdBETransaccao objStdTransac = new StdBETransaccao();

                try
                {
                    StdLoggingHandler.FileTrace("Calling AbrePlataformaEmpresa");
                    Plataforma.AbrePlataformaEmpresa(Company, objStdTransac, objAplConf, objTipoPlataforma);
                    StdLoggingHandler.FileTrace("Exit from AbrePlataformaEmpresa");
                }
                catch (Exception ex)
                {
                    StdLoggingHandler.FileTraceWithThrow(ex);
                    throw;
                }

                if (Plataforma.Inicializada)
                {
                    StdLoggingHandler.FileTrace("Calling AbreEmpresaTrabalho");
                    MotorLE.AbreEmpresaTrabalho(objTipoPlataforma, Company, User, Password, objStdTransac, Instance);
                    StdLoggingHandler.FileTrace("Exit from AbreEmpresaTrabalho");

                    Platform = Plataforma;
                    Engine = MotorLE;

                    EngineStatus = true;
                }

                return engineInstance;
            }
            catch (Exception ex)
            {
                StdLoggingHandler.FileTraceWithThrow(ex);
                throw;
            }
            finally
            {
                StdLoggingHandler.FileTraceExitMethod();
            }
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// The platform
        /// </summary>
        public static StdPlatBS Platform { get; private set; }

        /// <summary>
        /// The engine that allows access to the modules.
        /// </summary>
        public static ErpBS Engine { get; private set; }

        /// <summary>
        /// The engine status 0 - Fail | 1 - OK
        /// </summary>
        public static bool EngineStatus { get; private set; }

        #endregion
  
        #region IDisposable Members

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called
            if (!this.Disposed)
            {

            }

            // Dispose on base class
            base.Dispose(disposing);
        }
        #endregion
    }
}
