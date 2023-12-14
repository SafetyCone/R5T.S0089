using System;

using R5T.T0141;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface IHashCodeDemonstrations : IDemonstrationsMarker
    {
        /// <summary>
        /// How, in C# code, do you get a hashcode value for null?
        /// The <see cref="HashCode.Combine{T1}(T1)"/> method can do it.
        /// How can you do it?
        /// </summary>
        public void Get_HashCode_ForNull()
        {
            object a = null;

            //// System.NullReferenceException: 'Object reference not set to an instance of an object.'
            //var output = a.GetHashCode();

            // Use an instance of the hash code struct.
            var hashCode = new HashCode();

            hashCode.Add(a);

            var output = hashCode.ToHashCode();

            // -1074652840
            Console.WriteLine(output);
        }
    }
}
