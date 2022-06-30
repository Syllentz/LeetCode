using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeWork
{
    public class PalindromeNumbers
    {
        static void Main()
        {
            //Nothing
        }
        public bool IsPalindrome(int x)
        {
            bool result = false;
            string n = x.ToString();
            var charArray = n.ToCharArray();
            //List<string> palindrome = n.Select(digit => int.Parse(digit.ToString()));
            int backwardsNumber = charArray.Length;
            for (int i = 0; i < charArray.Length; i++)
            {
                backwardsNumber = charArray.Length -1 - i;
                if (backwardsNumber != i)
                {
                    if (charArray[i] != charArray[backwardsNumber])
                    {
                        return false;
                    }
                    result = true;
                }
                else
                {
                    return true;
                }
            }
            return result;
        }
    }
}
