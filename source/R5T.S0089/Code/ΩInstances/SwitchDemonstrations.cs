using System;


namespace R5T.S0089
{
    public class SwitchDemonstrations : ISwitchDemonstrations
    {
        #region Infrastructure

        public static ISwitchDemonstrations Instance { get; } = new SwitchDemonstrations();


        private SwitchDemonstrations()
        {
        }

        #endregion
    }
}
