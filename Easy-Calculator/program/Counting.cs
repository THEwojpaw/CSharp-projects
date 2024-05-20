using Easy_calculator.ValidationClasses;

namespace Easy_calculator
{
    public class Counting
    {
        public static double Count(double a, double b, string operation)
        {
            if (ValidateSign.Sign(operation))
            {
                if (string.IsNullOrEmpty(operation))
                {
                    Console.WriteLine("Podałeś nieprawidłową liczbę znaków!");
                    throw new ArgumentException("Podałeś nieprawidłową liczbę znaków !");
                }
                var opr = operation[0];
                return Count(a, b, opr);
            }
            else
                return 0;

            throw new ArgumentException("Podałeś nieprawidłową liczbę znaków !");
        }

        public static double Count(double a, double b, char operation)
        {
            try
            {
                if (b == 0 & operation == '/')
                {
                    Console.WriteLine("Nie dziel przez zero!");
                    throw new ArgumentException("Nie dziel przez zero!");
                }
                switch (operation)
                {
                    case '+':
                        return (a + b);
                    case '-':
                        return (a - b);
                    case '*':
                        return (a * b);
                    case '/':
                    case ':':
                        return (a / b);
                    default:
                        Console.WriteLine("Wprowadziłeś nieprawidłowy znak (operację)!");
                        throw new ArgumentException("Wprowadziłeś nieprawidłowy znak (operację)!");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wporwadzono niewłaściwe dane, spróbuj jeszcze raz.");
                return 0;
            }

        }
    }
}

