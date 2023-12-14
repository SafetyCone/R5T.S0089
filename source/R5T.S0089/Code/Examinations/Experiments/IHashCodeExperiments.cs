using System;

using R5T.T0141;
using R5T.T0225.T000;


namespace R5T.S0089
{
    [ExperimentsMarker]
    public partial interface IHashCodeExperiments : IExperimentsMarker
    {
        /// <summary>
        /// <para>What is the hashcode of an integer?</para>
        /// Result:
        /// Different each run.
        /// </summary>
        public void HashCode_Combine_OfInteger()
        {
            var x = 3;

            var hashCode = HashCode.Combine(x);

            // 1387919484, -2116164186
            Console.WriteLine(hashCode);
        }

        /// <summary>
        /// <para>What is the hashcode of an integer?</para>
        /// Result: just the integer itself (as expected).
        /// </summary>
        public void HashCode_OfInteger()
        {
            var x = 3;

            var hashCode = x.GetHashCode();

            // 3
            Console.WriteLine(hashCode);
        }

        /// <summary>
        /// <para>
        /// There is a <see cref="HashCode"/> struct (since .NET Standard 2.1) that can be instantiated, and then asked for its hash code integer value.
        /// What is that initial value?
        /// </para>
        /// Result:
        /// The initial value is always the same in each run, but different between runs.
        /// </summary>
        public void HashCode_OfMultipleInitializedHashCode()
        {
            var hashCodes = new[]
            {
                new HashCode(),
                new HashCode(),
                new HashCode(),
            };

            // All the same value, but different between runs:
            // 37835164
            // 37835164
            // 37835164
            // 1878044779
            // 1878044779
            // 1878044779
            foreach (var hashCode in hashCodes)
            {
                var value = hashCode.ToHashCode();

                Console.WriteLine(value);
            }
        }

        /// <summary>
        /// <para>
        /// There is a <see cref="HashCode"/> struct (since .NET Standard 2.1) that can be instantiated, and then asked for its hash code integer value.
        /// What is that initial value?
        /// </para>
        /// Result:
        /// The value is different each run.
        /// </summary>
        public void HashCode_OfInitializedHashCode()
        {
            var hashCode = new HashCode();

            var value = hashCode.ToHashCode();

            // -326923435, 1583717858
            Console.WriteLine(value);
        }

        /// <summary>
        /// <para>The <see cref="HashCode.Combine{T1}(T1)"/> method is generic. What does it do on null for instances of different types?</para>
        /// Result:
        /// The same value is provided for null, regardless of the "type" of the null reference.
        /// The value is different for each run.
        /// </summary>
        public void HashCode_CombineNull_DifferentTypes()
        {
            string a = null;
            object b = null;
            Class_001 c = null;

            var outputA = HashCode.Combine(a);
            var outputB = HashCode.Combine(b);
            var outputC = HashCode.Combine(c);

            // Same value for each run, different values across runs:
            // -926239213
            // -926239213
            // -926239213
            // -548725820
            // -548725820
            // -548725820
            Console.WriteLine(outputA);
            Console.WriteLine(outputB);
            Console.WriteLine(outputC);
        }

        /// <summary>
        /// <para>The <see cref="HashCode.Combine{T1}(T1)"/> method is generic. What does it do on null for different generic type parameters types?</para>
        /// Result:
        /// The same value is provided for null, no matter what type is specified for as the type argment for Combine().
        /// The value is different for each run.
        /// </summary>
        public void HashCode_CombineNull_DifferentTypeParameters()
        {
            var outputA = HashCode.Combine<string>(null);
            var outputB = HashCode.Combine<object>(null);
            var outputC = HashCode.Combine<Class_001>(null);

            // Same value for each run, different values across runs:
            // -688247467
            // -688247467
            // -688247467
            // -1382468795
            // -1382468795
            // -1382468795
            Console.WriteLine(outputA);
            Console.WriteLine(outputB);
            Console.WriteLine(outputC);
        }

        /// <summary>
        /// <para>What does the <see cref="HashCode.Combine{T1}(T1)"/> method do on null, when asked multiple times?</para>
        /// Result:
        /// The same value is provided per run, no matter how many times it is asked.
        /// But the value is different between runs.
        /// </summary>
        public void HashCode_CombineNull_MultipleTries()
        {
            var outputA = HashCode.Combine<string>(null);
            var outputB = HashCode.Combine<string>(null);
            var outputC = HashCode.Combine<string>(null);

            // Same value for each run, different values across runs:
            // -338758116
            // -338758116
            // -338758116
            // 47335472
            // 47335472
            // 47335472
            Console.WriteLine(outputA);
            Console.WriteLine(outputB);
            Console.WriteLine(outputC);
        }

        /// <summary>
        /// <para>What does the <see cref="HashCode.Combine{T1}(T1)"/> method do on null?</para>
        /// Result: 
        /// Provides a value (does not error).
        /// The value is different for each run.
        /// </summary>
        public void HashCode_CombineNull()
        {
            var output = HashCode.Combine<string>(null);

            // Multiple values per run: 528209213, -1801726071, etc.
            Console.WriteLine(output);
        }
    }
}
