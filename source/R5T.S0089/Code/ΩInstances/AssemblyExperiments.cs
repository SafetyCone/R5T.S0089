using System;


namespace R5T.S0089
{
    public class AssemblyExperiments : IAssemblyExperiments
    {
        #region Infrastructure

        public static IAssemblyExperiments Instance { get; } = new AssemblyExperiments();


        private AssemblyExperiments()
        {
        }

        #endregion
    }
}
