using LeetCode;
using static LeetCode.LinkListExample;
using static LeetCode.Tools.NodeList;
using static LeetCode.LeetCodeWork.LongestSubstring;
using LeetCode.LeetCodeWork;
using LeetCode.Tools;

namespace TestProject
{
    public class UnitTest1
    {
        /*
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
        */
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
        [Fact]
        public void LongestSubstringTest()
        {
            //LongestSubstring longestSubstring = new LongestSubstring(); 
            //string s = "abcabcbb";
            //int target = longestSubstring.LengthOfLongestSubstring(s);
            //Console.WriteLine(target);
            //Console.ReadLine();
        }

        [Fact]
        public void PalindromeTest()
        {
            PalindromeNumbers palindromeNumbers = new PalindromeNumbers();
            int n = 1123567;
            bool isPal = palindromeNumbers.IsPalindrome(n);
            Console.WriteLine(isPal);
            //Console.ReadLine();
            n = 123454321;
            isPal = palindromeNumbers.IsPalindrome(n);
            Console.WriteLine(isPal);
            //Console.ReadLine();
            n = 12344321;
            isPal = palindromeNumbers.IsPalindrome(n);
            Console.WriteLine(isPal);
            //Console.ReadLine();
        }
        [Fact]
        public void RomanToIntTest()
        {
            RomanToInteger romanToInteger = new RomanToInteger();
            string s = "III";
            int r = romanToInteger.RomanToInt(s);

            s = "LVIII";
            r = romanToInteger.RomanToInt(s);

            s = "MCMXCIV";
            r = romanToInteger.RomanToInt(s);
            Console.WriteLine(r);
        }
        [Fact]
        public void LongestPrefix()
        {
            LongestCommonPrefixL longestCommonPrefixL = new LongestCommonPrefixL();
            string[] s = { "flower", "flow", "flight" };
            string result = longestCommonPrefixL.LongestCommonPrefix(s);
            s = new string[] {"dog","racecar","car"};
            result = longestCommonPrefixL.LongestCommonPrefix(s);
            Console.WriteLine(result);
        }
        [Fact]
        public void OpenClosePara()
        {
            ValidParentheses validParentheses = new ValidParentheses();
            string s;
            s = "()";
            bool isV = validParentheses.IsValid(s);
            s = "()[]{}";
            isV = validParentheses.IsValid(s);
            s = "(]";
            isV = validParentheses.IsValid(s);
            Console.WriteLine(s);
        }
        [Fact]
        public void RecursionFactorialExample()
        {
            int i = 10;
            FactorialRecursion factorialRecursion = new FactorialRecursion();
            int result = factorialRecursion.Factorial(i);
            Console.WriteLine(result);
        }
    }
}