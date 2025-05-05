namespace Leetcode.CSharp.PalindromeNumber;

/// <summary>
/// <see cref="https://leetcode.com/problems/palindrome-number/"/>
/// Results: <see cref="https://leetcode.com/problems/palindrome-number/submissions/1625326882/"/>
/// </summary>
public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        string s = x.ToString();

        int i = 0;
        while (i < s.Length / 2 && s[i] == s[s.Length - i - 1])
        {
            i++;
        }
        
        return i == s.Length / 2;
    }
}