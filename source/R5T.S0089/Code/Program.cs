using System;


namespace R5T.S0089
{
    class Program
    {
        static void Main()
        {
            /// Demonstrations.
            //Demonstrations.Instance.Display_EnvironmentVariables();

            //CommandLineDemonstrations.Instance.Get_CommandLineArguments();

            //ExecutablePathDemonstrations.Instance.Get_ExecutableFilePath();
            //ExecutablePathDemonstrations.Instance.Get_ExecutableDirectoryPath();

            //FileSystemDemonstrations.Instance.Write_File();
            //FileSystemDemonstrations.Instance.Enumerate_FilePaths_Platform();
            //FileSystemDemonstrations.Instance.Enumerate_ChildFilePaths_Platform();
            //FileSystemDemonstrations.Instance.Enumerate_DescendantFilePaths_Platform();
            //FileSystemDemonstrations.Instance.Enumerate_DescendantFilePathsWithExtension_Platform();
            //FileSystemDemonstrations.Instance.Enumerate_DescendantFilePathsWithFileExtension_Platform();
            //FileSystemDemonstrations.Instance.Enumerate_DescendantFilePathsWithFileExtensionsBySearchPattern_Platform();
            //FileSystemDemonstrations.Instance.Enumerate_ChildFilePathsWithFileExtensionBySearchPattern();
            //FileSystemDemonstrations.Instance.Enumerate_DescendantFilePathsWithFileExtensionBySearchPattern();
            //FileSystemDemonstrations.Instance.Make_FilePath_ReadOnly();
            //FileSystemDemonstrations.Instance.Get_ExecutableDirectoryAssemblyFilePaths();

            //FlagDemonstrations.Instance.Has_Flag();

            //HashCodeDemonstrations.Instance.Get_HashCode_ForNull();

            //PathDemonstrations.Instance.Get_FileName();
            //PathDemonstrations.Instance.Get_ParentDirectoryPath_ForFile();

            //StringDemonstrations.Instance.Get_LastCharacter();

            //SwitchDemonstrations.Instance.SwitchOnTypeOfNullInstanceOfBaseType();

            /// Experiments.
            //AssemblyExperiments.Instance.Try_MetadataReader();
            //AssemblyExperiments.Instance.Get_AssemblyName();

            //HashCodeExperiments.Instance.HashCode_CombineNull();
            //HashCodeExperiments.Instance.HashCode_CombineNull_MultipleTries();
            //HashCodeExperiments.Instance.HashCode_CombineNull_DifferentTypeParameters();
            //HashCodeExperiments.Instance.HashCode_CombineNull_DifferentTypes();
            //HashCodeExperiments.Instance.HashCode_OfInitializedHashCode();
            //HashCodeExperiments.Instance.HashCode_OfMultipleInitializedHashCode();
            //HashCodeExperiments.Instance.HashCode_OfInteger();
            //HashCodeExperiments.Instance.HashCode_Combine_OfInteger();

            LinqExperiments.Instance.Select_OnNull();
        }
    }
}