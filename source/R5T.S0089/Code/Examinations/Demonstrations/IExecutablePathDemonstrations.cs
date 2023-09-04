using System;

using R5T.T0141;
using R5T.T0181;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface IExecutablePathDemonstrations : IDemonstrationsMarker
    {
        public void Get_ExecutableFilePath()
        {
            var executableFilePath = Instances.ExecutablePathOperator.Get_ExecutableFilePath();

            Console.WriteLine($"Executable file path:\n\t{executableFilePath}");
        }

        public void Get_ExecutableDirectoryPath()
        {
            var executableDirectoryPath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryPath();

            Console.WriteLine($"Executable directory path:\n\t{executableDirectoryPath}");
        }
    }
}
