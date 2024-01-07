using System;
using System.Runtime.InteropServices;

using R5T.T0141;


namespace R5T.S0089
{
    [DemonstrationsMarker]
    public partial interface IDemonstrations : IDemonstrationsMarker
    {
        public void Display_Environment()
        {
            /// Inputs.
            var outputFilePath = Instances.FilePaths.OutputTextFilePath;


            /// Run.
            Instances.FileOperator.In_WriterContext_Synchronous(
                outputFilePath,
                writer =>
                {
                    writer.WriteLine($"\n--- {nameof(RuntimeInformation)} ---\n");

                    writer.WriteLine($"{nameof(RuntimeInformation.FrameworkDescription)}:\n\t{RuntimeInformation.FrameworkDescription}");
                    writer.WriteLine($"{nameof(RuntimeInformation.OSArchitecture)}:\n\t{RuntimeInformation.OSArchitecture}");
                    writer.WriteLine($"{nameof(RuntimeInformation.OSDescription)}:\n\t{RuntimeInformation.OSDescription}");
                    writer.WriteLine($"{nameof(RuntimeInformation.ProcessArchitecture)}:\n\t{RuntimeInformation.ProcessArchitecture}");
                    writer.WriteLine($"{nameof(RuntimeInformation.RuntimeIdentifier)}:\n\t{RuntimeInformation.RuntimeIdentifier}");

                    writer.WriteLine($"\n--- {nameof(RuntimeEnvironment)} ---\n");

                    writer.WriteLine($"{nameof(RuntimeEnvironment.GetRuntimeDirectory)}:\n\t{RuntimeEnvironment.GetRuntimeDirectory()}");
                    writer.WriteLine($"{nameof(RuntimeEnvironment.GetSystemVersion)}:\n\t{RuntimeEnvironment.GetSystemVersion()}");

                    writer.WriteLine($"\n--- {nameof(Environment)} ---\n");

                    Instances.EnvironmentOperator.DescribeTo(writer);

                    writer.WriteLine($"\n--- {nameof(GC)} ---\n");

                    writer.WriteLine($"{nameof(GC.GetAllocatedBytesForCurrentThread)}:\n\t{GC.GetAllocatedBytesForCurrentThread()}");

                    writer.WriteLine($"{nameof(GC.GetTotalAllocatedBytes)}:\n\t{GC.GetTotalAllocatedBytes(true)}");
                    writer.WriteLine($"{nameof(GC.GetTotalMemory)}:\n\t{GC.GetTotalMemory(true)}");

                    writer.WriteLine($"\n--- {nameof(GCMemoryInfo)} ---\n");

                    var gcMemoryInfo = GC.GetGCMemoryInfo();

                    writer.WriteLine($"{nameof(gcMemoryInfo.TotalAvailableMemoryBytes)}:\n\t{gcMemoryInfo.TotalAvailableMemoryBytes}");
                    writer.WriteLine($"{nameof(gcMemoryInfo.TotalCommittedBytes)}:\n\t{gcMemoryInfo.TotalCommittedBytes}");
                });

            Instances.NotepadPlusPlusOperator.Open(outputFilePath);
        }

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
