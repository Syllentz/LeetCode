using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSumExample
    {
        /*
        public static void Main()
        {
            NumberGen createArray = new NumberGen();
            int target = 7;
            int numEntries = 20;
            int[] nums = createArray.CreateArray(numEntries, 10);
            int[] results = TwoSum(nums,target);
            Console.WriteLine("The two numbers are: {0},{1}", results[0],results[1]) ; 
            Console.ReadLine();
        }*/
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                result[0] = i;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j!=i)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            result[1] = j;
                            return result;
                        }
                    }
                }
                result[0] = 0;
            }            
            return result;
        }
    }
}
