using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeWork
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            if (s.Length < 2)  return false;
            var charArray = s.ToArray();
            List<char> openChars = new List<char>();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (IsOpenChar(charArray[i]))
                {
                    openChars.Add(charArray[i]);
                }
                else
                {
                    if (openChars.Count < 1) return false;
                    if (IsPair(openChars[openChars.Count-1], charArray[i]))
                    {
                        openChars.RemoveAt(openChars.Count-1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (openChars.Count > 0)
            {
                return false;
            }
            else return true;
        }
        public bool IsOpenChar(char c)
        {
            switch (c)
            {
                case '(': return true;
                case '{': return true;
                case '[': return true;
                default: return false;
            }
        }
        public bool IsPair(char openC, char closeC)
        {
            switch (openC)
            {
                case '(':
                    if (closeC == ')') 
                    {
                        return true;
                    }
                    else return false;
                case '{':
                    if (closeC == '}')
                    {
                        return true;
                    }
                    else return false;
                case '[':
                    if (closeC == ']')
                    {
                        return true;
                    }
                    else return false;
                default: return false;
            }
        }
    }
}
