using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;
using R5T.T0179.Extensions;
using R5T.T0180;


namespace R5T.S0089
{
    [FunctionalityMarker]
    public partial interface IConsoleOperator : IFunctionalityMarker
    {
        public void Display_FilePaths(IEnumerable<IFilePath> filePaths)
        {
            this.Display_FilePaths(filePaths.Get_Values());
        }

        public void Display_FilePaths(IEnumerable<string> filePaths)
        {
            var orderedPaths = filePaths
                .OrderAlphabetically()
                .Now();

            if(orderedPaths.IsEmpty())
            {
                Console.WriteLine("<No file paths>");

                return;
            }

            foreach (var filePath in orderedPaths)
            {
                Console.WriteLine(filePath);
            }

            Console.WriteLine($"{orderedPaths.Length}: count");
        }
    }
}
