using System.Text.RegularExpressions;

namespace Easy_calculator.ValidationClasses
{
    public class ValidateSign
    {
        public static bool Sign(string sign)
        {
            return sign.Length == 1;
        }
        public static bool ValidateSignRG(string sign)
        {
            Regex rg = new Regex("^[+\\-*\\/:]$");
            if (!rg.IsMatch(sign))
            {
                Console.WriteLine("Wprowadziłeś nieprawidłowy znak (operację)!");
                return false;
            }

            return true;
        }
    }
}
