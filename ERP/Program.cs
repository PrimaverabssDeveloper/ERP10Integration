using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Primavera.Erp.Sample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.Run(new frmMain());
        }

        /// <summary>
        /// Resolving Assembly
        /// </summary>
        /// <param name="sender">Application</param>
        /// <param name="args">Resolving Assembly Name</param>
        /// <returns>Assembly</returns>
        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string assemblyFullName;
            
            System.Reflection.AssemblyName assemblyName;
            
            assemblyName = new System.Reflection.AssemblyName(args.Name);
            assemblyFullName = System.IO.Path.Combine(Environment.GetEnvironmentVariable("PERCURSOSGE100", EnvironmentVariableTarget.Machine), assemblyName.Name + ".dll");
            
            if (System.IO.File.Exists(assemblyFullName))
                return System.Reflection.Assembly.LoadFile(assemblyFullName);
            else
                return null;
        }
    }
}
