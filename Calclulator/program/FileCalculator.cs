using Kalkulator_txt.BaseOperations;
using Kalkulator_txt.ListOperations;

namespace Kalkulator_txt.Calculators
{
    public static class FileCalculator
    {
        public static void CalculateWithFile()
        {
            Console.WriteLine("Przetwarzanie twojego pliku.");

            List<int> numbers = new();
            List<string> signs = new();
            List<double> results = new();
            List<string> exceptionResults = new();

            using StreamReader InputFile = new(@"./numbers.txt");
            using StreamWriter OutputFile = new(@"./results.txt");

            while (!InputFile.EndOfStream)
            {
                var lineContent = InputFile.ReadLine();
                if (lineContent == null) break;

                lineContent?.Trim().Replace(" ", "");

                numbers = ListConversion.ListOfStringToListOfInt(ListCreation.MatchPatternRangeAndInsertToList(lineContent, @"\d{1,}"));
                signs = ListCreation.MatchPatternRangeAndInsertToList(lineContent, @"[\+-\/\*]");

                if (numbers.Count <= 0 | signs.Count <= 0)
                {
                    string mistake = "Wykryto bład w linii.";
                    exceptionResults.Add(mistake);
                    continue;
                }
                else
                    results.Add(Calculations.Calculate(signs[0], numbers));
            }
            for (int i = 0; i < results.Count; i++)
            {
                if (exceptionResults.Count == 0) OutputFile.WriteLine(results[i]);
                else if (exceptionResults[i] == "Wykryto bład w linii") OutputFile.WriteLine(exceptionResults[i]);
                else OutputFile.WriteLine(results[i]);
            }
            Console.WriteLine("Zakończono proces.");
        }
    }
}
