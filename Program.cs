using Kalkulator_txt.Calculators;

namespace Kalkulator_txt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            repeat:
            Console.WriteLine("W jaki sposób chcesz użyć kalkulatora? Odczytać działania z pliku i zapisać rozwiązania do drugiego (naciśnij 1) LUB podanć własne działania na bieżąco(naciśnij 2)");
            choice = Console.ReadLine();
            if (choice == "1") 
            {
                FileCalculator.CalculateWithFile();
                
                Console.WriteLine("Czy chcesz użyć kalkulatora jescze raz? (Jeśli nie naciśnij Y, jeśli tak naciśnij inny dowolny klawisz.)");
                string again = Console.ReadLine();
                if (again == "y" | again == "Y")    Console.WriteLine("Zakończono działanie aplikacji.");
                else goto repeat;
            }
            else if (choice == "2")
            {
               ConsoleCalculator.CalculateWithConsole();

               Console.WriteLine("Czy chcesz użyć kalkulatora jescze raz? (Jeśli nie naciśnij Y, jeśli tak naciśnij inny dowolny klawisz.)");
               string again = Console.ReadLine();
               if (again == "y" | again == "Y")     Console.WriteLine("Zakończono działanie aplikacji.");
               else goto repeat;
            }
            else
            {
                Console.WriteLine("Podałeś nieprawidłowe dane, spróbuj jeszcze raz.");
                goto repeat;
            }
        }
            //TODO mogę wybrac, czy obliczam dane z pliku, czy podaje z klawiatury z konsoli. 
            //TODO program działa dopoku nie nacisne Y
    }
}