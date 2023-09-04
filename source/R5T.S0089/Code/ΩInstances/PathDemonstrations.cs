using System;


namespace R5T.S0089
{
    public class PathDemonstrations : IPathDemonstrations
    {
        #region Infrastructure

        public static IPathDemonstrations Instance { get; } = new PathDemonstrations();


        private PathDemonstrations()
        {
        }

        #endregion
    }
}
