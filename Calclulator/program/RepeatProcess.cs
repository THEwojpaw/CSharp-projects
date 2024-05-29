namespace Kalkulator_txt
{
    public static class RepeatProcess
    {
        public static bool Again()
        {
            Console.WriteLine("Czy chcesz użyć kalkulatora jescze raz? (Jeśli nie naciśnij N, jeśli tak naciśnij inny dowolny klawisz.)");
            string again = Console.ReadLine() ?? throw new ArgumentException("Brak danych w linii");
            if (again.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Zakończono działanie aplikacji.");
                return true;
            }
            return false;
        }
    }
}
