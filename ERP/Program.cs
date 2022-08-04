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
            string assemblyProgramFilesX86FullName;
            string assemblyProgramFilesFullName;
            AssemblyName assemblyName;

            string PRIMAVERA_FOLDER = "PRIMAVERA\\SG100\\Apl";
            string environmentVariablesProgramFilesX86 = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%");
            string environmentVariablesProgramFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%");

            assemblyName = new AssemblyName(args.Name);

            var PERCURSOSGE100 = Environment.GetEnvironmentVariable("PERCURSOSGE100", EnvironmentVariableTarget.Machine);

            if (!string.IsNullOrWhiteSpace(PERCURSOSGE100))
            {
                assemblyFullName = Path.Combine(PERCURSOSGE100, assemblyName.Name + ".dll");
            }
            else
            {
                assemblyFullName = Path.Combine(Path.Combine(@"C:\", PRIMAVERA_FOLDER), assemblyName.Name + ".dll");
            }

            assemblyProgramFilesX86FullName = Path.Combine(Path.Combine(environmentVariablesProgramFilesX86, PRIMAVERA_FOLDER), assemblyName.Name + ".dll");
            assemblyProgramFilesFullName = Path.Combine(Path.Combine(environmentVariablesProgramFiles, PRIMAVERA_FOLDER), assemblyName.Name + ".dll");

            if (File.Exists(assemblyFullName))
            {
                return Assembly.LoadFile(assemblyFullName);
            }
            else if (File.Exists(assemblyProgramFilesX86FullName))
            {
                return Assembly.LoadFile(assemblyProgramFilesX86FullName);
            }
            else if (File.Exists(assemblyProgramFilesFullName))
            {
                return Assembly.LoadFile(assemblyProgramFilesFullName);
            }
            else
            {
                //Por causa dos Resources do ERP !!!
                assemblyProgramFilesX86FullName = Path.Combine(Path.Combine(environmentVariablesProgramFilesX86, PRIMAVERA_FOLDER + "\\pt"), assemblyName.Name + ".dll");
                assemblyProgramFilesFullName = Path.Combine(Path.Combine(environmentVariablesProgramFiles, PRIMAVERA_FOLDER + "\\pt"), assemblyName.Name + ".dll");
                if (File.Exists(assemblyProgramFilesX86FullName))
                {
                    return Assembly.LoadFile(assemblyProgramFilesX86FullName);
                }
                else if (File.Exists(assemblyProgramFilesFullName))
                {
                    return Assembly.LoadFile(assemblyProgramFilesFullName);
                }
                else
                {
                    //Por causa do Processo de CefSharp !!!
                    assemblyProgramFilesX86FullName = Path.Combine(Path.Combine(environmentVariablesProgramFilesX86, PRIMAVERA_FOLDER + "\\X86"), assemblyName.Name + ".dll");
                    assemblyProgramFilesFullName = Path.Combine(Path.Combine(environmentVariablesProgramFiles, PRIMAVERA_FOLDER + "\\X64"), assemblyName.Name + ".dll");
                    if (File.Exists(assemblyProgramFilesX86FullName))
                    {
                        return Assembly.LoadFile(assemblyProgramFilesX86FullName);
                    }
                    else if (File.Exists(assemblyProgramFilesFullName))
                    {
                        return Assembly.LoadFile(assemblyProgramFilesFullName);
                    }
                    else
                    {
                        //Por causa do Processo de HuRakan !!!
                        assemblyProgramFilesX86FullName = Path.Combine(Path.Combine(environmentVariablesProgramFilesX86, PRIMAVERA_FOLDER + "\\HUR\\pt"), assemblyName.Name + ".dll");
                        assemblyProgramFilesFullName = Path.Combine(Path.Combine(environmentVariablesProgramFiles, PRIMAVERA_FOLDER + "\\HUR\\pt"), assemblyName.Name + ".dll");
                        if (File.Exists(assemblyProgramFilesX86FullName))
                        {
                            return Assembly.LoadFile(assemblyProgramFilesX86FullName);
                        }
                        else if (File.Exists(assemblyProgramFilesFullName))
                        {
                            return Assembly.LoadFile(assemblyProgramFilesFullName);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}
