using System;


namespace R5T.S0089
{
    public class HashCodeExperiments : IHashCodeExperiments
    {
        #region Infrastructure

        public static IHashCodeExperiments Instance { get; } = new HashCodeExperiments();


        private HashCodeExperiments()
        {
        }

        #endregion
    }
}
