using System;
using System.Windows.Forms;

namespace Primavera.PlatformSamples
{
    static class Program
    {
        const string PRIMAVERA_FOLDER = "PRIMAVERA\\SG100\\Apl";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.Run(new frmLogin());
        }

        /// <summary>
        /// Resolving Assembly
        /// </summary>
        /// <param name="sender">Application</param>
        /// <param name="args">Resolving Assembly Name</param>
        /// <returns>Assembly</returns>
        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            var assemblyName = new System.Reflection.AssemblyName(args.Name);
            var assemblyFullName = System.IO.Path.Combine(GetDllsFolder(), assemblyName.Name + ".dll");

            if (System.IO.File.Exists(assemblyFullName))
            {
                return System.Reflection.Assembly.LoadFile(assemblyFullName);
            }

            return null;
        }

        private static string GetDllsFolder()
        {
            string m_strDllsLocation = Environment.GetEnvironmentVariable("PERCURSOSGE100", EnvironmentVariableTarget.Machine);

            if (string.IsNullOrEmpty(m_strDllsLocation))
            {
                m_strDllsLocation = Environment.GetEnvironmentVariable("PERCURSOSGP100", EnvironmentVariableTarget.Machine);
            }

            if (string.IsNullOrEmpty(m_strDllsLocation))
            {
                m_strDllsLocation = Environment.GetEnvironmentVariable("PERCURSOSGV100", EnvironmentVariableTarget.Machine);
            }

            if (string.IsNullOrEmpty(m_strDllsLocation))
            {
                m_strDllsLocation = Environment.GetEnvironmentVariable("PERCURSOXRP100", EnvironmentVariableTarget.Machine);
            }

            if (string.IsNullOrEmpty(m_strDllsLocation))
            {
                m_strDllsLocation = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), PRIMAVERA_FOLDER);
            }

            return m_strDllsLocation;
        }
    }
}
