using System;
using R5T.T0141;
using R5T.T0225.T000;

namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface ISwitchDemonstrations : IDemonstrationsMarker
    {
        /// <summary>
        /// If you are performing a runtime switch on type, using an instance of a base type, that happens to be null, what happens?
        /// Result: 
        /// </summary>
        public void SwitchOnTypeOfNullInstanceOfBaseType()
        {
            DerivedType_001 derivedTypeInstance = null;

            bool Internal(BaseType_001 baseTypeInstance)
            {
                var output = baseTypeInstance switch
                {
                    // CS8121: An expression of type 'BaseType_001' cannot be handled by a pattern of type 'Class_001'.R5T.S0089
                    //Class_001 class_001 => Instances.NullOperator.Is_Null(class_001),
                    DerivedType_001 derivedType_001 => Instances.NullOperator.Is_Null(derivedType_001),
                    DerivedType_002 derivedType_002 => Instances.NullOperator.Is_Null(derivedType_002),
                    null => true,
                    // Will hit the default! (Basically, the switch expression is using GetType() on the instances.
                    _ => throw new Exception($"{baseTypeInstance}: Unrecognized type."),
                };

                return output;
            }

            var isNull = Internal(derivedTypeInstance);

            Console.WriteLine(isNull);
        }
    }
}
