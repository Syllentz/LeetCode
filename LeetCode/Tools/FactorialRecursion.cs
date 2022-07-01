using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tools
{
    public class FactorialRecursion
    {
        public int Factorial(int i)
        {
            if (i == 0) return 1;
            int result = i * Factorial(i - 1);
            return result;
        }
    }
}
