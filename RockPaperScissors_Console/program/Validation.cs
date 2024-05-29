using System.Text.RegularExpressions;

namespace KamienPapierNozyce_Console
{
    public static class Validation
    {
        public static bool IsSignInGamesRange(string input)
        {
            Regex rg = new Regex(@"^[x,i,o,X,I,O,L,e,E]$");
            if (!rg.IsMatch(input))
            {
                Console.WriteLine();
                Console.WriteLine("Podałeś niewłaściwy znak!!! Spróbuj jeszce raz.");
                return false;
            }
            return true;
        }
    }
}
