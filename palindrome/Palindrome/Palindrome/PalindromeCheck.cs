using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public static class PalindromeCheck
    {
        public static bool Check(string someString)
        {
            someString = ProcessString.RemoveSpecialCharacters(someString);
            someString = ProcessString.LowerCase(someString);

            if (ProcessString.CheckPalindrome(someString)) { return true; }
            else { return false; }

        }
    }
}
