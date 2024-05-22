using System.Text.RegularExpressions;

namespace Kalkulator_txt.Extensives
{
    public class ListCreation
    {
        public static List<string> MatchPatternRangeAndInsertToList(string arguments, string pattern)
        {
            var rg = new Regex(pattern);
            if (rg.IsMatch(arguments))
            {
                return rg.Matches(arguments)
                    .Select(e => e.Value)
                    .ToList();
            }

            return new List<string>();
        }

    }
}

