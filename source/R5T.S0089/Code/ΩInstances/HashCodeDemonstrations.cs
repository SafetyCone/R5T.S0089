using System;


namespace R5T.S0089
{
    public class HashCodeDemonstrations : IHashCodeDemonstrations
    {
        #region Infrastructure

        public static IHashCodeDemonstrations Instance { get; } = new HashCodeDemonstrations();


        private HashCodeDemonstrations()
        {
        }

        #endregion
    }
}
