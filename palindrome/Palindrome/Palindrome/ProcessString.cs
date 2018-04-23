using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    static public class ProcessString
    {
        static public string RemoveSpecialCharacters(string someString)
        {
            return new string(someString.Where(c => char.IsLetterOrDigit(c)).ToArray());
        }

        static public string LowerCase(string someString)
        {
            return someString.ToLower();
        }

        static public bool CheckPalindrome(string someString)
        {
            int lower = 0;
            int upper = someString.Length - 1;

            while (lower < upper)
            {
                if (someString[lower] != someString[upper])
                    return false;

                lower++;
                upper--;
            }

            return true;
        }
    }
}
