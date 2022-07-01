using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tools
{
    public class NumberGen
    {
        public int[] CreateArray(int i, int scalingFactor)
        {
            Random random = new Random();
            int[] array = new int[i];
            int roundedVar = 0;
            for (int j = 0; j < i; j++)
            {
                roundedVar = (int)(random.NextDouble() * scalingFactor);
                array[j] = roundedVar;
            }
            return array;
        }
    }
}
