using System;


namespace R5T.S0089
{
    public class StringDemonstrations : IStringDemonstrations
    {
        #region Infrastructure

        public static IStringDemonstrations Instance { get; } = new StringDemonstrations();


        private StringDemonstrations()
        {
        }

        #endregion
    }
}
