using System;
using System.Collections.Generic;

using R5T.T0131;
using R5T.T0180;


namespace R5T.S0089
{
    [ValuesMarker]
    public partial interface IOperations : IValuesMarker
    {
        public void Enumerate_FilePaths(
            IDirectoryPath directoryPath,
            Func<IDirectoryPath, IEnumerable<IFilePath>> filePathEnumerator)
        {
            var filePaths = filePathEnumerator(directoryPath);

            Instances.ConsoleOperator.Display_FilePaths(filePaths);
        }
    }
}
