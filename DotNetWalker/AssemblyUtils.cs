using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace DotNetWalker
{
    public class AssemblyUtils
    {
        public delegate void AssemblyNotFound(AssemblyName assembly);

        public event AssemblyNotFound OnAssemblyNotFound;

        /// <summary>
        /// Load assembly from physical path
        /// </summary>
        /// <param name="assemblyFilePath">Physical path of assembly file</param>
        /// <returns>Loaded assembly</returns>
        private Assembly LoadAssemblyFromFile(string assemblyFilePath)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (assembly.Location == assemblyFilePath)
                {
                    return assembly;
                }
            }

            return Assembly.ReflectionOnlyLoadFrom(assemblyFilePath);
        }

        /// <summary>
        /// Load assembly using assembly name
        /// </summary>
        /// <param name="asmName"></param>
        /// <returns>Loaded assembly</returns>
        private Assembly LoadAssemblyByName(AssemblyName asmName)
        {
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
                if (assembly.FullName == asmName.FullName)
                    return assembly;

            return Assembly.Load(asmName);
        }

        /// <summary>
        /// Extract refrenced assemblies recursively
        /// </summary>
        /// <param name="assemblyFilePath">Physical path of assembly file</param>
        /// <param name="excludeDotNetAssemblies">Determine we should exclude orginal .Net assemblies or not</param>
        /// <param name="alreadyAnalyzed">Determine this assembly is already analyzed</param>
        /// <returns></returns>
        public List<Assembly> GetReferencedAssemblies(string assemblyFilePath, bool excludeDotNetAssemblies,
            List<Assembly> alreadyAnalyzed)
        {
            var asmList = new List<Assembly>();
            var assembly = LoadAssemblyFromFile(assemblyFilePath);

            var referencedAssemblies = assembly.GetReferencedAssemblies();

            foreach (var assemblyName in referencedAssemblies)
            {
                try
                {
                    Assembly asm = LoadAssemblyByName(assemblyName);
                    var versionInfo = FileVersionInfo.GetVersionInfo(asm.Location);

                    // Check the result must exclude Microsoft .Net assemblies or not
                    // if the result must exclude Microsoft .Net assemblies exclude theme
                    if (excludeDotNetAssemblies)
                    {
                        if (!versionInfo.ProductName.ToLower().Contains(@"Microsoft® .NET Framework".ToLower()))
                            asmList.Add(asm);
                    }
                    else
                        asmList.Add(asm);
                }
                catch (Exception ex)
                {
                    var foundedAssembly = FindAssemblyInsideExecutable(Path.GetDirectoryName(assemblyFilePath), assemblyName);
                    if (foundedAssembly != null)
                        asmList.Add(foundedAssembly);
                    else
                        OnAssemblyNotFound?.Invoke(assemblyName);
                }
            }

            alreadyAnalyzed.Add(assembly);
            var subAssemblies = new List<Assembly>();
            var a = asmList.Except(alreadyAnalyzed);
            foreach (var asm in a)
                if (File.Exists(asm.Location))                
                    subAssemblies.AddRange(GetReferencedAssemblies(asm.Location, excludeDotNetAssemblies, alreadyAnalyzed));               
            
            asmList.AddRange(subAssemblies);

            return asmList.Distinct().ToList();
        }

        /// <summary>
        /// Search for specified assembly info in given path and if assembly found return it
        /// </summary>
        /// <param name="executablePath">Path that search in it</param>
        /// <param name="mustFindAssembly">Assembly info for search</param>
        /// <returns></returns>
        private Assembly FindAssemblyInsideExecutable(string executablePath, AssemblyName mustFindAssembly)
        {
            foreach (var file in Directory.GetFiles(executablePath))
            {
                try
                {
                    Assembly currentAssembly = LoadAssemblyFromFile(file);

                    if (currentAssembly.FullName == mustFindAssembly.FullName)
                        return currentAssembly;

                }
                catch (Exception ex)
                {
                }
            }

            return null;
        }
    }
}