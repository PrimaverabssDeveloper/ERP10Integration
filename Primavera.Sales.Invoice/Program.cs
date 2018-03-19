using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Primavera.Sales.Invoice
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

            //Este handler tem que ser adicionado antes de existir qualquer referência para classes existentes nos Interop's,
            //isto é, no método Main() da aplicação NÃO PODERÁ EXISTIR DECLARAÇÕES DE VARIÁVEIS DE TIPOS EXISTENTES NOS INTEROPS.
            //Com este método, na pasta da aplicação não deverão existir os Interops e as referências para os mesmos deverão ser
            //adicionadas com Copy Local = False e Specific Version = false.
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.Run(new Login());
        }

        /// <summary>
        /// Método para resolução das assemblies.
        /// </summary>
        /// <param name="sender">Application</param>
        /// <param name="args">Resolving Assembly Name</param>
        /// <returns>Assembly</returns>
        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string assemblyFullName;
            
            System.Reflection.AssemblyName assemblyName;
            
            const string PRIMAVERA_COMMON_FILES_FOLDER = "PRIMAVERA\\SG900"; 
            
            assemblyName = new System.Reflection.AssemblyName(args.Name);
            assemblyFullName = System.IO.Path.Combine(System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86), PRIMAVERA_COMMON_FILES_FOLDER), assemblyName.Name + ".dll");
            
            if (System.IO.File.Exists(assemblyFullName))
                return System.Reflection.Assembly.LoadFile(assemblyFullName);
            else
                return null;
        }
    }
}
