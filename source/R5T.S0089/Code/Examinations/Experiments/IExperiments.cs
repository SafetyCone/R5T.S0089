using System;
using System.Threading.Tasks;

using R5T.T0141;


namespace R5T.S0089
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        /// <summary>
        /// What is the default value of <see cref="Task"/>?
        /// <para>
        /// Result: null, as kinda expected for a reference type.
        /// </para>
        /// </summary>
        public void WhatIsTheDefaultOfTask()
        {
            Task task = default;

            // False.
            var isCompleted = task == Task.CompletedTask;

            // True.
            var isNull = task == null;

            Console.WriteLine(task);
        }

        /// <summary>
        /// What is the index of the empty string, in the empty string?
        /// <para>
        /// Result: index is 0 (zero). Not an error.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Inspired by: <see href="https://news.ycombinator.com/item?id=38630968"/>,
        /// which is discussion of: <see href="https://successfulsoftware.net/2023/12/13/what-is-the-index-of-an-empty-string-in-an-empty-string/"/>
        /// </remarks>
        public void IndexOfEmptyStringInEmptyString()
        {
            var emptyString = Instances.Strings.Empty;

            // 0
            var indexOf = emptyString.IndexOf(emptyString);

            Console.WriteLine($"Index of: {indexOf}");

            // 0
            indexOf = emptyString.IndexOf("");

            Console.WriteLine($"Index of: {indexOf}");

            // 0
            indexOf = "".IndexOf(emptyString);

            Console.WriteLine($"Index of: {indexOf}");

            // 0
            indexOf = "".IndexOf("");

            Console.WriteLine($"Index of: {indexOf}");
        }

        /// <summary>
        /// What is the index of an empty string in a non-empty string?
        /// <para>
        /// Result: index is 0 (zero). Not an error.
        /// </para>
        /// </summary>
        /// <inheritdoc cref="IndexOfEmptyStringInEmptyString" path="/remarks"/>
        public void IndexOfEmptyStringInString()
        {
            var nonEmptyString = Instances.Strings.ExampleString;

            var emptyString = Instances.Strings.Empty;

            // 0
            var indexOf = nonEmptyString.IndexOf(emptyString);

            Console.WriteLine($"Index of: {indexOf}");

            /// What about testing for a string in the empty string?
            // -1
            indexOf = emptyString.IndexOf(nonEmptyString);

            Console.WriteLine($"Index of: {indexOf}");
        }
    }
}
