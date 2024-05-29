namespace KamienPapierNozyce_Console
{
    public static class GameMechanics
    {
        /* win - 1  
         * lose - 2   
         * exit - 0 
         * wrong - 9
         */
        public static ConsoleKey MyItem()
        {
            Random rnd = new();

            ConsoleKey[] items = { ConsoleKey.X, ConsoleKey.I, ConsoleKey.O };
            return items[rnd.Next(items.Length)];             
        }

        public static ConsoleKey TheirItem()
        {
            bool repeatCondition;
            do 
            {
                Console.WriteLine("Wybierz swój przedmiot lub zakończ: ");
                var item = Console.ReadKey();
                if (item.Key != ConsoleKey.L)
                {
                    Validation.IsSignInGamesRange(item.Key.ToString());
                    return item.Key;
                }
                Validation.IsSignInGamesRange(item.Key.ToString());
                return item.Key;
            }while (!repeatCondition);

        }

        public static int Fight(ConsoleKey myItem, ConsoleKey theirItem)
        {
            return myItem switch
            {
                ConsoleKey.X => theirItem switch
                {
                    ConsoleKey.I => 2,
                    ConsoleKey.O => 1,
                    ConsoleKey.L => 1,
                    ConsoleKey.E => 0,
                    ConsoleKey.X => 3,
                    _ => 9,
                },
                ConsoleKey.I => theirItem switch
                {
                    ConsoleKey.X => 1,
                    ConsoleKey.O => 2,
                    ConsoleKey.L => 1,
                    ConsoleKey.E => 0,
                    ConsoleKey.I => 3,
                    _ => 9,
                },
                ConsoleKey.O => theirItem switch
                {
                    ConsoleKey.X => 2,
                    ConsoleKey.I => 1,
                    ConsoleKey.L => 1,
                    ConsoleKey.E => 0,
                    ConsoleKey.O => 3,
                    _ => 9,
                },
                _ => 9,
            };
        }
    }
}
