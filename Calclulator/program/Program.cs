using Kalkulator_txt.Calculators;

namespace Kalkulator_txt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            bool end;
            do
            {
                Console.WriteLine("W jaki sposób chcesz użyć kalkulatora? Odczytać działania z pliku i zapisać rozwiązania do drugiego (naciśnij 1) LUB podanć własne działania na bieżąco(naciśnij 2)");
                choice = Console.ReadLine() ?? throw new ArgumentException("Brak danych w linii");
                if (choice == "1")
                {
                    FileCalculator.CalculateWithFile();

                    end = RepeatProcess.Again();
                }
                else if (choice == "2")
                {
                    ConsoleCalculator.CalculateWithConsole();

                    end = RepeatProcess.Again();
                }
                else
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane, spróbuj jeszcze raz.");
                    end = false;
                }
            } while (!end);
        }
    }
}