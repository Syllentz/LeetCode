using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeWork
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            int tempResult = 0;
            var charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                tempResult = ConvertRomanToInt(charArray[i]);
                if (i == charArray.Length-1)
                {
                    result = result + tempResult;
                }
                else if (tempResult >= ConvertRomanToInt(charArray[i+1]))
                {
                    result = result + tempResult;
                }
                else
                {
                    result = result + (ConvertRomanToInt(charArray[i + 1]) - tempResult);
                    i++;
                }
            }
            return result;
        }
        public int ConvertRomanToInt(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
    }
}
