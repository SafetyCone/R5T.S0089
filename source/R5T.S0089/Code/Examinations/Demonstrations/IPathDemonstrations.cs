using System;

using R5T.T0141;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface IPathDemonstrations : IDemonstrationsMarker
    {
        public void Get_ParentDirectoryPath_ForFile()
        {
            /// Inputs.
            var filePath = Instances.FilePaths.Example;


            /// Run.
            var parentDirectoryPath = Instances.PathOperator.Get_ParentDirectoryPath_ForFile(filePath.Value);

            Console.WriteLine($"{parentDirectoryPath}:\n\t{filePath}");
        }

        public void Get_FileName()
        {
            /// Inputs.
            var filePath = Instances.FilePaths.Example;


            /// Run.
            var fileName = Instances.PathOperator.Get_FileName(filePath.Value);

            Console.WriteLine($"{fileName}:\n\t{filePath}");
        }
    }
}
