using System;


namespace R5T.S0089
{
    public class LinqExperiments : ILinqExperiments
    {
        #region Infrastructure

        public static ILinqExperiments Instance { get; } = new LinqExperiments();


        private LinqExperiments()
        {
        }

        #endregion
    }
}
