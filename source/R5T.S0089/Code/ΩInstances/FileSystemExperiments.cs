using System;


namespace R5T.S0089
{
    public class FileSystemExperiments : IFileSystemExperiments
    {
        #region Infrastructure

        public static IFileSystemExperiments Instance { get; } = new FileSystemExperiments();


        private FileSystemExperiments()
        {
        }

        #endregion
    }
}
