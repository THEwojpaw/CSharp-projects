using System.Text.RegularExpressions;

namespace Easy_calculator.Validations
{
    public class ValidateSign
    {
        public static bool ValidateIfSignIsInRange(string sign)
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
