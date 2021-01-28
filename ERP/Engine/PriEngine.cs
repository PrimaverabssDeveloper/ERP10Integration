﻿using ErpBS100;
using Primavera.Extensibility.Engine;
using StdBE100;
using StdPlatBS100;
using System;
using static StdBE100.StdBETipos;

namespace Primavera.Erp.Sample
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

        public static PriEngine CreatContext(string Company, string User, string Password)
        {
            StdBSConfApl objAplConf = new StdBSConfApl();
            StdPlatBS Plataforma = new StdPlatBS();
            ErpBS MotorLE = new ErpBS();

            EnumTipoPlataforma objTipoPlataforma;
            objTipoPlataforma = EnumTipoPlataforma.tpEmpresarial;

            objAplConf.Instancia = "Default";
            objAplConf.AbvtApl = "ERP";
            objAplConf.PwdUtilizador = Password;
            objAplConf.Utilizador = User;
            objAplConf.LicVersaoMinima = "10.00";

            StdBETransaccao objStdTransac = new StdBETransaccao();

            try
            {
                Plataforma.AbrePlataformaEmpresa(Company, objStdTransac, objAplConf, objTipoPlataforma);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            if (Plataforma.Inicializada)
            {
                MotorLE.AbreEmpresaTrabalho(objTipoPlataforma, Company, User, Password, objStdTransac, "Default");

                // Use this service to trigger the API events.
                ExtensibilityService service = new ExtensibilityService();

                // Suppress all message box events from the API.
                // Plataforma.ExtensibilityLogger.AllowInteractivity = false;
                service.Initialize(MotorLE);

                // Check if service is operational
                if (service.IsOperational)
                {
                    // Inshore that all extensions are loaded.
                    service.LoadExtensions();
                }

                Platform = Plataforma;
                Engine = MotorLE;

                if (MotorLE != null && Plataforma.BDInicializada)
                {
                    //Inicializa o SDK
                    PriSDKContexto = new PRISDK100.clsSDKContexto();
                    PriSDKContexto.Inicializa(MotorLE, ConstantesPrimavera100.Modulos.Vendas);
                    PriSDKContexto.InicializaPlataforma(Platform);
                }

                EngineStatus = true;
            }

            return engineInstance;
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// The platform
        /// </summary>
        public static StdPlatBS Platform { get; set; }

        /// <summary>
        /// The engine that allows access to the modules.
        /// </summary>
        public static ErpBS Engine { get; set; }

        /// <summary>
        /// The engine status 0 - Fail | 1 - OK
        /// </summary>
        public static bool EngineStatus { get; private set; }

        /// <summary>
        /// SDK Context
        /// </summary>
        public static PRISDK100.clsSDKContexto PriSDKContexto { get; private set; }

        #endregion

        #region IDisposable Members

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
