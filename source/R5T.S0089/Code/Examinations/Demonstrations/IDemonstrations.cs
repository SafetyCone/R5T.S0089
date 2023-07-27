using System;

using R5T.T0141;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Display_EnvironmentVariables()
        {
            /// Inputs.
            var outputFilePath = Instances.FilePaths.OutputTextFilePath;


            /// Run.
            Instances.FileOperator.In_WriterContext_Synchronous(
                outputFilePath,
                writer => Instances.EnvironmentOperator_F0124_N000.Display_EnvironmentVariables(
                    writer));

            Instances.NotepadPlusPlusOperator.Open(outputFilePath);
        }
    }
}
