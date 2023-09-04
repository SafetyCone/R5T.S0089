using System;

using R5T.T0141;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface ICommandLineDemonstrations : IDemonstrationsMarker
    {
        public void Get_CommandLineArguments()
        {
            var arguments = Instances.CommandLineArgumentsOperator.Get_CommandLineArguments();

            foreach (var argument in arguments)
            {
                Console.WriteLine(argument);
            }
        }
    }
}
