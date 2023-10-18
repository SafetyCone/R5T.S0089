using System;

using R5T.T0141;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface IStringDemonstrations : IDemonstrationsMarker
    {
        /// <summary>
        /// Get the last character of a string.
        /// </summary>
        public void Get_LastCharacter()
        {
            /// Inputs.
            var @string = Instances.Strings._Platform.Example;


            /// Run.
            var lastCharacter = Instances.StringOperator.Get_LastCharacter(@string);

            Console.WriteLine($"{lastCharacter}, last character of:\n\t{@string}");
        }
    }
}
