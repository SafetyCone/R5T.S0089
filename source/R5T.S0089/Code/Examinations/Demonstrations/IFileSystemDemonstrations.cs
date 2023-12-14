using System;
using System.Collections.Generic;

using R5T.T0141;
using R5T.T0180;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface IFileSystemDemonstrations : IDemonstrationsMarker
    {
        public void Get_ExecutableDirectoryAssemblyFilePaths()
        {
            var executableDirectoryPath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryPath();

            var assemblyFilePaths = Instances.FileSystemOperator.Get_DllFilePaths(executableDirectoryPath);

            Console.WriteLine($"{assemblyFilePaths.Length}: count");

            foreach (var assemblyFilePath in assemblyFilePaths)
            {
                Console.WriteLine(assemblyFilePath);
            }
        }

        public void Enumerate_DescendantFilePathsWithFileExtension_Platform()
        {
            /// Inputs.
            var directoryPath = Instances.DirectoryPaths.Temp.Value;
            var fileExtension =
                Instances.FileExtensions._Platform.Text
                ;
            Func<string, IEnumerable<string>> enumerator =
                Instances.FileSystemOperator._Platform.Get_Enumerate_FilePaths_ByFileExtension(fileExtension)
                ;


            /// Run.
            var filePaths = enumerator(directoryPath);

            Instances.ConsoleOperator.Display_FilePaths(filePaths);
        }

        public void Enumerate_ChildFilePathsWithFileExtensionBySearchPattern()
        {
            /// Inputs.
            var directoryPath =
                Instances.DirectoryPaths.Temp
                ;

            var fileExtension =
                Instances.FileExtensions.Json
                //Instances.FileExtensions.Text
                ;
            var searchPattern = Instances.SearchPatternGenerator.Files_WithExtension(
               fileExtension);
            Func<IDirectoryPath, IEnumerable<IFilePath>> filePathEnumerator =
                Instances.FileSystemOperator.Get_Enumerate_ChildFilePaths(searchPattern)
                ;


            /// Run.
            Instances.Operations.Enumerate_FilePaths(
                directoryPath,
                filePathEnumerator);
        }

        public void Enumerate_DescendantFilePathsWithFileExtensionBySearchPattern()
        {
            /// Inputs.
            var directoryPath =
                Instances.DirectoryPaths.Temp
                ;

            var fileExtension =
                Instances.FileExtensions.Json
                //Instances.FileExtensions.Text
                ;
            var searchPattern = Instances.SearchPatternGenerator.Files_WithExtension(
               fileExtension);
            Func<IDirectoryPath, IEnumerable<IFilePath>> filePathEnumerator =
                Instances.FileSystemOperator.Get_Enumerate_DescendantFilePaths(searchPattern)
                ;


            /// Run.
            Instances.Operations.Enumerate_FilePaths(
                directoryPath,
                filePathEnumerator);
        }

        public void Enumerate_DescendantFilePathsWithFileExtensionsBySearchPattern_Platform()
        {
            /// Inputs.
            var directoryPath =
                Instances.DirectoryPaths.Temp.Value
                ;
            //var fileExtensions = new[]
            //{
            //    Instances.FileExtensions.Json,
            //    Instances.FileExtensions.Text,
            //};
            Func<string, string, IEnumerable<string>> enumerator =
                Instances.FileSystemOperator._Platform.Enumerate_ChildFilePaths
                //Instances.FileSystemOperator.Enumerate_DescendantFilePaths
                ;


            /// Run.
            var searchPattern = "*txt|*json";

            var filePaths = enumerator(
                directoryPath,
                searchPattern);

            Instances.ConsoleOperator.Display_FilePaths(filePaths);
        }

        public void Enumerate_DescendantFilePathsWithFileExtensionBySearchPattern_Platform()
        {
            /// Inputs.
            var directoryPath =
                Instances.DirectoryPaths.Temp.Value
                ;
            var fileExtension =
                Instances.FileExtensions._Platform.Text
                ;
            Func<string, string, IEnumerable<string>> enumerator =
                Instances.FileSystemOperator._Platform.Enumerate_ChildFilePaths
                //Instances.FileSystemOperator.Enumerate_DescendantFilePaths
                ;


            /// Run.
            var searchPattern = Instances.SearchPatternGenerator.Files_WithExtension(fileExtension);

            var filePaths = enumerator(
                directoryPath,
                searchPattern);

            Instances.ConsoleOperator.Display_FilePaths(filePaths);
        }

        public void Enumerate_DescendantFilePathsWithSearchPattern_Platform()
        {
            /// Inputs.
            var directoryPath =
                Instances.DirectoryPaths.Temp.Value
                ;
            var searchPattern =
                Instances.SearchPatterns.All
                ;
            Func<string, string, IEnumerable<string>> enumerator =
                Instances.FileSystemOperator._Platform.Enumerate_ChildFilePaths
                //Instances.FileSystemOperator.Enumerate_DescendantFilePaths
                ;


            /// Run.
            var filePaths = enumerator(
                directoryPath,
                searchPattern);

            Instances.ConsoleOperator.Display_FilePaths(filePaths);
        }

        public void Enumerate_DescendantFilePaths_Platform()
        {
            /// Inputs.
            var directoryPath = Instances.DirectoryPaths.Temp.Value;


            /// Run.
            var filePaths = Instances.FileSystemOperator._Platform.Enumerate_DescendantFilePaths(directoryPath);

            Instances.ConsoleOperator.Display_FilePaths(filePaths);
        }

        public void Enumerate_ChildFilePaths_Platform()
        {
            /// Inputs.
            var directoryPath = Instances.DirectoryPaths.Temp.Value;


            /// Run.
            var filePaths = Instances.FileSystemOperator._Platform.Enumerate_ChildFilePaths(directoryPath);

            Instances.ConsoleOperator.Display_FilePaths(filePaths);
        }

        public void Enumerate_FilePaths_Platform()
        {
            /// Inputs.
            var directoryPath = Instances.DirectoryPaths.Temp.Value;


            /// Run.
            var filePaths = Instances.FileSystemOperator._Platform.Enumerate_FilePaths(directoryPath);

            Instances.ConsoleOperator.Display_FilePaths(filePaths);
        }

        public void Make_FilePath_ReadOnly()
        {
            /// Inputs.
            var filePath = Instances.FilePaths.OutputTextFilePath;


            /// Run.
            Instances.FileSystemOperator._Platform.Make_ReadOnly(filePath.Value);

            Console.WriteLine(filePath);
        }

        public void Write_File()
        {
            /// Inputs.
            var filePath = Instances.FilePaths.OutputTextFilePath;
            var text = Instances.TextValues.Basic_Text;


            /// Run.
            Instances.FileOperator.Write_Text_Synchronous(
                filePath.Value,
                text.Value);

            Instances.NotepadPlusPlusOperator.Open(filePath);
        }
    }
}
