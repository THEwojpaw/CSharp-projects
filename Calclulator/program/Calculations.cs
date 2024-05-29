namespace Kalkulator_txt.BaseOperations
{
    public static class Calculations
    {
        public static double Calculate(string operation, List<int> digits)
        {
            return digits.Skip(1)
                .Aggregate((double)digits[0], 
                (result, digit) => Counting.Count(result, digit, operation));
        }
    }
}
