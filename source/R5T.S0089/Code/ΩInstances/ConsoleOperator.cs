using System;


namespace R5T.S0089
{
    public class ConsoleOperator : IConsoleOperator
    {
        #region Infrastructure

        public static IConsoleOperator Instance { get; } = new ConsoleOperator();


        private ConsoleOperator()
        {
        }

        #endregion
    }
}
