using System;


namespace R5T.S0089
{
    public class ExecutablePathDemonstrations : IExecutablePathDemonstrations
    {
        #region Infrastructure

        public static IExecutablePathDemonstrations Instance { get; } = new ExecutablePathDemonstrations();


        private ExecutablePathDemonstrations()
        {
        }

        #endregion
    }
}
