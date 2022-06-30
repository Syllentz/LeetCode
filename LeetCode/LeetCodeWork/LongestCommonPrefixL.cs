using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeWork
{
    public class LongestCommonPrefixL
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string result = "";
            string tempResult = "";
            bool flag = false;
            foreach (char c in strs[0])
            {
                tempResult = tempResult + c;
                for (int i = 1; i < strs.Length; i++)
                {
                    if (strs[i].Length < tempResult.Length)
                    {
                        flag = true;
                        break;
                    }
                    if (strs[i].Substring(0,tempResult.Length) != tempResult)
                    {
                        flag = true;
                        break;                        
                    }                    
                }
                if (flag) { break; }
                result = tempResult;
            }
            return result;
        }
    }
}
