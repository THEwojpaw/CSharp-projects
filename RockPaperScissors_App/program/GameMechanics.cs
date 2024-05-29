namespace KamienPapierNozyce_Console
{
    public static class GameMechanics
    {
        /* win - 1    kamień - 1
         * lose - 2   papier - 2
         * draw - 3   nożyce - 3
         * wrong - 9
         */
        public static int MyItem()
        {
            Random rnd = new();

            int[] items = { 1, 2, 3 };
            return items[rnd.Next(items.Length)];
        }

        public static int Fight(int myItem, int theirItem)
        {
            return myItem switch
            {
                3 => theirItem switch
                {
                    2 => 2,
                    1 => 1,
                    3 => 3,
                    _ => 9,
                },
                2 => theirItem switch
                {
                    3 => 1,
                    1 => 2,
                    2 => 3,
                    _ => 9,
                },
                1 => theirItem switch
                {
                    3 => 2,
                    2 => 1,
                    1 => 3,
                    _ => 9,
                },
                _ => 9,
            };
        }
    }
}
