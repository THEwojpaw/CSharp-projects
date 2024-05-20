using System;
using System.Text.RegularExpressions;
namespace Easy_calculator;

public class Calculator
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Podaj pierwszą liczbę: ");
            string input1 = Console.ReadLine();
            if (!Validate.ValidateInput(input1, out int a))
            {
                continue;
            }

            Console.WriteLine("Podaj działanie jakie chcesz wykonać(dodawanie +, odejmowanie -, mnożenie * lub dzielenie /): ");
            string operation = Console.ReadLine();

            if (!ValidateRG.SignRG(operation))
            {
                continue;
            }

            Console.WriteLine("Podaj drugą liczbę: ");
            string input2 = Console.ReadLine();
            if (!Validate.ValidateInput(input2, out int b))
            {
                continue;
            }

            double outcome = Counting.Count(a, b, operation);
            Console.WriteLine($"{a} {operation} {b} = {outcome} ");

            Console.WriteLine("Jeśli chcesz użyć kalkulatora jeszcze raz wpisz Y, jeżeli nie wpisz inny dowolny klawisz.");
            string answer = Console.ReadLine();
            if (answer == "Y" | answer == "y")
            {
                continue;
            }
            else
                break;
        }
    }
}
      

