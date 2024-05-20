namespace Easy_calculator
{
    public class Validate
    {
        public static bool ValidateInput(string input, out int result)
        {
            if (!int.TryParse(input, out result))
            {
                Console.WriteLine("Podałeś nieprawidłowy składnik!");
                return false;
            }

            return true;
        }
    }
}
