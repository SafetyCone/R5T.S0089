using System;


namespace R5T.S0089
{
    public class CommandLineDemonstrations : ICommandLineDemonstrations
    {
        #region Infrastructure

        public static ICommandLineDemonstrations Instance { get; } = new CommandLineDemonstrations();


        private CommandLineDemonstrations()
        {
        }

        #endregion
    }
}
