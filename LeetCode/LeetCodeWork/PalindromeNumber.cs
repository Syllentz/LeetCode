using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public bool IsPalindrome(int x)
	{
		string n = x.ToString();
		List<int> palindrome = n.ToCharArray();
		int backwardsNumber = palindrome.Count;
		for (int i = 0; i < palindrome.Count; i++)
        {
			backwardsNumber--;
            if (backwardsNumber!=i)
            {
				return true;
            }
            if (palindrome(i) != palindrome(backwardsNumber))
            {
				return false;
            }
        }
		return true;
	}
}
