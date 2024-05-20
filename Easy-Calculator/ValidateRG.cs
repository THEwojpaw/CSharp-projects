using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Easy_calculator
{
    public class ValidateRG
    {
        public static bool SignRG(string sign)
        {
            Regex rg = new Regex("^[+\\-*\\/:]$");
            if(!rg.IsMatch(sign))
            {
                Console.WriteLine("Wprowadziłeś nieprawidłowy znak (operację)!");
                return false;
            }
       
            return true;
        }
    }
}

