using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Primavera.Erp.Sample
{
    static class Program
    {
        private static string PERCURSOSG = "";

        /// <summary>The main entry point for the application.</summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            Application.Run(new frmMain());
        }

        /// <summary>Resolving Assembly.</summary>
        /// <param name="sender">Application</param>
        /// <param name="args">Resolving Assembly Name</param>
        /// <returns>Assembly</returns>
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string assemblyFullName;
            string assemblyProgramFilesX86FullName;
            string assemblyProgramFilesFullName;
            AssemblyName assemblyName;

            string PRIMAVERA_FOLDER = "PRIMAVERA\\SG100\\Apl";
            string environmentVariablesProgramFilesX86 = Environment.ExpandEnvironmentVariables("%ProgramFiles(x86)%");
            string environmentVariablesProgramFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%");

            assemblyName = new AssemblyName(args.Name);

            if (string.IsNullOrEmpty(PERCURSOSG))
            {
                PERCURSOSG = Environment.GetEnvironmentVariable("PERCURSOXRP100", EnvironmentVariableTarget.Machine);
                
                if (string.IsNullOrEmpty(PERCURSOSG))
                {
                    PERCURSOSG = Environment.GetEnvironmentVariable("PERCURSOSGV100", EnvironmentVariableTarget.Machine);
                }

                if (string.IsNullOrEmpty(PERCURSOSG))
                {
                    PERCURSOSG = Environment.GetEnvironmentVariable("PERCURSOSGE100", EnvironmentVariableTarget.Machine);
                }

                if (string.IsNullOrEmpty(PERCURSOSG))
                {
                    PERCURSOSG = Environment.GetEnvironmentVariable("PERCURSOSGP100", EnvironmentVariableTarget.Machine);
                }

                if (string.IsNullOrEmpty(PERCURSOSG))
                {
                    PERCURSOSG = Path.Combine(@"C:\", PRIMAVERA_FOLDER);
                }
            }

            assemblyFullName = Path.Combine(PERCURSOSG, assemblyName.Name + ".dll");
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
