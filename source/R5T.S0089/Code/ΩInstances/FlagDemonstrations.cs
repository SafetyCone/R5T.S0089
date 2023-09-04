using System;


namespace R5T.S0089
{
    public class FlagDemonstrations : IFlagDemonstrations
    {
        #region Infrastructure

        public static IFlagDemonstrations Instance { get; } = new FlagDemonstrations();


        private FlagDemonstrations()
        {
        }

        #endregion
    }
}
