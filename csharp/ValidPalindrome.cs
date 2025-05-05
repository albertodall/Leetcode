namespace Leetcode.CSharp.ValidPalindrome;

/// <summary>
/// <see cref="https://leetcode.com/problems/valid-palindrome/"/>
/// Results: <see cref="https://leetcode.com/problems/valid-palindrome/submissions/1625080712/"/> 
/// </summary>
public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        char[] chars = s.Where(c => char.IsAsciiLetterOrDigit(c))
                        .Select(c => c)
                        .ToArray();
                        
        int i = 0;
        while (i < chars.Length / 2 && 
               char.ToLowerInvariant(chars[i]) == char.ToLowerInvariant(chars[chars.Length - i - 1]))
        {
            i++;
        }

        return i == chars.Length / 2;
    }
}