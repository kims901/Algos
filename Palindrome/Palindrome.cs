using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Palindrome
{
    public class Palindrome
    {

        public bool IsPalindromeRecursive(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            if (input.Length == 1) return true;

            return input[0] == input[input.Length - 1] &&
                (input.Substring(1, input.Length - 2) == "" ? true : IsPalindromeRecursive(input.Substring(1, input.Length - 2)));

        }
    }
}
