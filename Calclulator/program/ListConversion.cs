namespace Kalkulator_txt.ListOperations
{
    public static class ListConversion
    {
        public static List<int> ListOfStringToListOfInt(List<string> listToConvert)
        {
            return listToConvert.Select(element =>
            {
                var result = int.TryParse(element, out int trans);
                if (!result)
                {
                    Console.WriteLine("Wykryto nieprawidłowe dane!");
                    throw new ArgumentException("Wykryto nieprawidłowe dane!");
                }
                return trans;
            }).ToList();
        }
    }
}
