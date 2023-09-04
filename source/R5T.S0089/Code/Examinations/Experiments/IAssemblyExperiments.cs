using System;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

using R5T.T0141;
using R5T.T0172.Extensions;


namespace R5T.S0089
{
    [ExperimentsMarker]
    public partial interface IAssemblyExperiments : IExperimentsMarker
    {
        public void Get_AssemblyName()
        {
            /// Inputs.
            var assemblyFilePath =
                //Instances.FilePaths.Example_Assembly
                Instances.ExecutablePathOperator._Platform.Get_Path_ExecutableDirectoryRelative("R5T.T0213.dll")
                    .ToAssemblyFilePath();
                ;


            /// Run.
            var assemblyName = Instances.AssemblyOperator.Get_AssemblyName(assemblyFilePath);

            Console.WriteLine(assemblyName);
            Console.WriteLine($"{assemblyName.FullName}: full-name");
            Console.WriteLine($"{assemblyName.Name}: name");
        }

        /// <summary>
        /// <see href="https://learn.microsoft.com/en-us/dotnet/api/system.reflection.metadata.metadatareader?view=net-7.0"/>
        /// </summary>
        public void Try_MetadataReader()
        {
            /// Inputs
            // Use the path of an example, lone, DLL.
            var assemblyFilePath =
                //// An executable.
                //@"C:\Temp\R5T.S0089.dll"
                //// A non-executable library.
                //@"C:\Temp\R5T.T0131.dll"
                //// A supposedly non-.NET DLL.
                //@"C:\Temp\mscoree.dll"
                // A text file.
                @"C:\Temp\log.txt"
                ;


            using var fileStream = new FileStream(assemblyFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            //PEStreamOptions
            using var portableExecutableReader = new PEReader(fileStream);

            var x = portableExecutableReader.IsEntireImageAvailable;
            var y = portableExecutableReader.GetEntireImage();

            MetadataReader metadataReader = portableExecutableReader.GetMetadataReader();

            foreach (TypeDefinitionHandle typeDefinitionHandle in metadataReader.TypeDefinitions)
            {
                TypeDefinition typeDefinition = metadataReader.GetTypeDefinition(typeDefinitionHandle);

                string namespaceName = metadataReader.GetString(typeDefinition.Namespace);

                string typeName = metadataReader.GetString(typeDefinition.Name);

                Console.WriteLine($"{namespaceName}.{typeName}");
            }
        }
    }
}
