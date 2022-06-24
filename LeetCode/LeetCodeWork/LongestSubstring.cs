using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeWork
{
    public class LongestSubstring
    {
        public static void Main()
        {
            LongestSubstring longestSubstring = new LongestSubstring();
            string s = "abcabcbb";
            int target = longestSubstring.LengthOfLongestSubstring(s);
            Console.WriteLine(target);
            Console.ReadLine();
        }
        public int LengthOfLongestSubstring(string s)
        {
            List<string> list = new List<string>();
            foreach (var item in s)
            {
                list.Add(item.ToString());
            }
            int longest = 0;
            string curString = "";
            List<string> nS = new List<string>();
            for(int i = 0; i<=list.Count;i++)
            {               
                if (nS.Where<list => list.Contains())
                {

                }
            }
            return longest;
        }
    }
}
