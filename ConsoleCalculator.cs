using Easy_calculator.Validations;
using Kalkulator_txt.BaseOperations;

namespace Kalkulator_txt.Calculators
{
    public static class ConsoleCalculator
    {
        public static void CalculateWithConsole()
        {
            while (true)
            {
                Console.WriteLine("Podaj pierwszą liczbę: ");
                string input1 = Console.ReadLine();
                if (!ValidateInput.ValidateInputType(input1, out int a))
                {
                    continue;
                }

                Console.WriteLine("Podaj działanie jakie chcesz wykonać(dodawanie +, odejmowanie -, mnożenie * lub dzielenie /): ");
                string operation = Console.ReadLine();

                if (!ValidateSign.ValidateIfSignIsInRange(operation))
                {
                    continue;
                }

                Console.WriteLine("Podaj drugą liczbę: ");
                string input2 = Console.ReadLine();
                if (!ValidateInput.ValidateInputType(input2, out int b))
                {
                    continue;
                }

                double outcome = Counting.Count(a, b, operation);
                Console.WriteLine($"{a} {operation} {b} = {outcome} ");

                Console.WriteLine("Jeśli chcesz zakończyć wpisz Y, jeżeli nie wpisz inny dowolny klawisz.");
                string answer = Console.ReadLine();
                if (answer == "Y" | answer == "y")
                {
                    break;
                }
                else
                    continue;
            }
        }
    }
}
