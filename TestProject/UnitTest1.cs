using LeetCode;
using static LeetCode.LinkListExample;
using static LeetCode.Tools.NodeList;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void LinkListExample()
        {
            ListNode l1 = new ListNode();
            l1.
            ListNode l1 =  //[2, 4, 3];
            ListNode l2 = [5, 6, 4];
            ListNode result = AddTwoNumbers(l1, l2);
            Console.WriteLine("The two numbers are: {0}", result.val);
            Console.ReadLine();
        }
        [Fact]
        public void TwoSumTest()
        {
            NumberGen createArray = new NumberGen();
            int target = 7;
            int numEntries = 20;
            int[] nums = createArray.CreateArray(numEntries, 10);
            int[] results = TwoSumExample.TwoSum(nums, target);
            Console.WriteLine("The two numbers are: {0},{1}", results[0], results[1]);
            Console.ReadLine();
        }
    }
}