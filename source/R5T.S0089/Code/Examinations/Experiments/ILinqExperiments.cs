using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0141;


namespace R5T.S0089
{
    [ExperimentsMarker]
    public partial interface ILinqExperiments : IExperimentsMarker
    {
        /// <summary>
        /// <para>
        /// The Select() LINQ method is an extension method, which is just syntactic sugar for a static method.
        /// Since static methods can have null inputs, we should be able to call the extension method on a null value.
        /// </para>
        /// Result: throws an exception saying that value cannot be null.
        /// </summary>
        public void Select_OnNull()
        {
            IEnumerable<string> items = null;

            // System.ArgumentNullException: 'Value cannot be null. (Parameter 'source')'
            var output = items.Select(x => x);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
