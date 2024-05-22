namespace Kalkulator_txt.BaseOperations
{
    public static class Calculations
    {
        public static double Calculate(string operation, List<int> digits)
        {
            double result = digits[0];

            foreach (var digit in digits.Skip(1))
            {
                result = Counting.Count(result, digit, operation);
            }
            return result;
        }
    }
}
