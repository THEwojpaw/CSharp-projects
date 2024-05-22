namespace Kalkulator_txt.ListOperations
{
    public static class ListConversion
    {
        public static List<int> ListOfStringToListOfInt(List<string> listToConvert)
        {
            var transition = listToConvert.Select(element =>
            {
                var result = int.TryParse(element, out int trans);
                if (result == false)
                {
                    Console.WriteLine("Wykryto nieprawidłowe dane!");
                    throw new ArgumentException("Wykryto nieprawidłowe dane!");
                }
                return trans;
            }).ToList();
            return transition;
        }
    }
}

