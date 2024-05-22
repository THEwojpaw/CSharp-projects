namespace Kalkulator_txt.Extensives
{
    public static class ListConversion
    {
        public static List<int> ListOfStringToListOfInt(List<string> listToConvert)
        {
            List<int> transition = new();
            foreach (var element in listToConvert)
            {
                var result = int.TryParse(element, out int trans);
                if (result == false)
                {
                    Console.WriteLine("Wykryto nieprawidłowe dane!");
                    throw new ArgumentException("Wykryto nieprawidłowe dane!");
                }
                transition.Add(trans);
            }
            return transition;
        }
    }
}
