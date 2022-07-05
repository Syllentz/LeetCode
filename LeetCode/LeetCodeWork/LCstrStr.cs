using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeWork
{
    internal class LCstrStr
    {
        public int StrStr(string haystack, string needle)
        {
            int result = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return result;
        }
    }
}
