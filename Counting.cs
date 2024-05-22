namespace Kalkulator_txt.BaseOperations
{
    public static class Counting
    {
        public static double Count(double a, double b, string operation)
        {
            try
            {
                if (b == 0 & operation == "/")
                {
                    Console.WriteLine("Wykryto dzielenie przez zero.");
                    throw new ArgumentException("Wykryto dzielenie przez zero.");
                }

                switch (operation)
                {
                    case "+":
                        return a + b;
                    case "-":
                        return a - b;
                    case "*":
                        return a * b;
                    case "/":
                    case ":":
                        return a / b;
                    default:
                        Console.WriteLine("Wykryto nieprawidłowy znak (operację)!");
                        return 0;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wykryto niewłaściwe dane, spróbuj jeszcze raz.");
                return 0;
            }

        }
    }
}
