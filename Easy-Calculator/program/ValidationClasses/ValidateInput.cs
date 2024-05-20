namespace Easy_calculator.ValidationClasses
{
    public class ValidateInput
    {
        public static bool ValidateInputType(string input, out int result)
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
