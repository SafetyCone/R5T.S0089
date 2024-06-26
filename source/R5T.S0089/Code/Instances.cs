using System;


namespace R5T.S0089
{
    public class Instances :
        L0055.Instances
    {
        public static L0057.IAssemblyOperator AssemblyOperator => L0057.AssemblyOperator.Instance;
        public static L0056.IAssemblyNameOperator AssemblyNameOperator => L0056.AssemblyNameOperator.Instance;
        public static L0057.ICommandLineArgumentsOperator CommandLineArgumentsOperator => L0057.CommandLineArgumentsOperator.Instance;
        public static new IConsoleOperator ConsoleOperator => S0089.ConsoleOperator.Instance;
        public static F0000.IEnvironmentOperator EnvironmentOperator => F0000.EnvironmentOperator.Instance;
        public static F0124.N000.IEnvironmentOperator EnvironmentOperator_F0124_N000 => F0124.N000.EnvironmentOperator.Instance;
        public static L0066.IFileExtensions FileExtensions => L0066.FileExtensions.Instance;
        public static new F0124.IFileOperator FileOperator => F0124.FileOperator.Instance;
        public static L0053.IFlagsOperator FlagsOperator => L0053.FlagsOperator.Instance;
        public static Z0061.IFlags Flags => Z0061.Flags.Instance;
        public static L0053.INullOperator NullOperator => L0053.NullOperator.Instance;
        public static IOperations Operations => S0089.Operations.Instance;
        public static L0057.ISearchPatternGenerator SearchPatternGenerator => L0057.SearchPatternGenerator.Instance;
        public static L0053.ISearchPatterns SearchPatterns => L0053.SearchPatterns.Instance;
        public static L0057.IStringOperator StringOperator => L0057.StringOperator.Instance;
        public static new IStrings Strings => S0089.Strings.Instance;
        public static Z0061.ITextValues TextValues => Z0061.TextValues.Instance;
    }
}