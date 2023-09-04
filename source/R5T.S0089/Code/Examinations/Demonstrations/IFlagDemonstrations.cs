using System;

using R5T.T0141;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface IFlagDemonstrations : IDemonstrationsMarker
    {
        public void Has_Flag()
        {
            /// Inputs.
            var flagAB = Instances.Flags.Flag_AB;
            var flagA = Instances.Flags.Flag_A;
            var flagC = Instances.Flags.Flag_C;


            /// Run.
            var hasA = Instances.FlagsOperator.Has_Flag(
                flagAB,
                flagA);

            var hasC = Instances.FlagsOperator.Has_Flag(
                flagAB,
                flagC);

            Console.WriteLine($"{hasA}: '{flagAB}' has flag '{flagA}'.");
            Console.WriteLine($"{hasC}: '{flagAB}' has flag '{flagC}'.");
        }
    }
}
