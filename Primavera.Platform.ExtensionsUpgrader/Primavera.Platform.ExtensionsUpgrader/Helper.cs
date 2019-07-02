using System;
using System.IO;
using System.Reflection;

namespace Primavera.Platform.ExtensionsUpgrader
{
    internal static class Helper
    {
        /// <summary>
        /// The installation path
        /// </summary>
        internal static string Installation_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"PRIMAVERA\SG100\Apl");

        /// <summary>
        /// Resolving Assembly
        /// </summary>
        /// <param name="sender">Application</param>
        /// <param name="args">Resolving Assembly Name</param>
        /// <returns>Assembly</returns>
        internal static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name);
            var assemblyFullName = Path.Combine(Installation_Path, assemblyName.Name + ".dll");

            if (File.Exists(assemblyFullName)) return Assembly.LoadFile(assemblyFullName);

            return null;
        }
    }
}