namespace KamienPapierNozyce_Console
{
    public class Game
    {
        public static void Main(string[] args)
        {

            Console.WriteLine(Statements.Initialization);
            Console.WriteLine(Statements.Initialization2);
            var choice = Console.ReadKey(); 
            if (choice.Key == ConsoleKey.Y)    
            {
                Console.WriteLine();
                Console.WriteLine(Statements.Tutorial1);
                Console.WriteLine(Statements.Tutorial2);
                Console.WriteLine(Statements.Tutorial3);
                Console.WriteLine(Statements.Tutorial4);
                Console.WriteLine(Statements.Tutorial5);
                Console.WriteLine(Statements.StartGame);
                Console.WriteLine();
            }
            else Console.WriteLine(Statements.StartGame);

            int myPoints = 0;
            int theirPoints = 0;
            bool exit = false;

            do
            {
                ConsoleKey myItem = GameMechanics.MyItem();
                Console.WriteLine(Statements.RoundStart);
                ConsoleKey theirItem = GameMechanics.TheirItem();
                if (theirItem == ConsoleKey.L)
                {
                    Console.WriteLine();
                    Console.WriteLine(Statements.PistolStatement);
                    theirPoints += 1;
                    exit = true;
                }
                else if (GameMechanics.Fight(myItem, theirItem) == 1)
                {
                    Console.WriteLine();
                    theirPoints += 1;
                    Console.WriteLine(Statements.ItemStatement + myItem + Statements.Win);
                }

                else if (GameMechanics.Fight(myItem, theirItem) == 2)
                {
                    Console.WriteLine();
                    myPoints += 1;
                    Console.WriteLine(Statements.ItemStatement + myItem + Statements.Lose);
                }
                else if (GameMechanics.Fight(myItem, theirItem) == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine(Statements.ItemStatement + myItem + Statements.Draw);
                }
                else if (GameMechanics.Fight(myItem, theirItem) == 0) exit = true;
            } while (!exit);

            string result;
            if (myPoints > theirPoints) result = Statements.LoseGame;
            else if (myPoints < theirPoints) result = Statements.WinGame;
            else if (myPoints == theirPoints) result = Statements.DrawGame;
            else throw new ArgumentException("Błąd w wynikach.");
            Console.WriteLine(Statements.Result + theirPoints + Statements.Result2 + myPoints + Statements.Point);
            Console.WriteLine(result);
        }
    }
}