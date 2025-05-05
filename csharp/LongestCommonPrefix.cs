namespace Leetcode.CSharp.LongestCommonPrefix;

/// <summary>
/// <see cref="https://leetcode.com/problems/longest-common-prefix/"/>
/// Results: <see cref="https://leetcode.com/problems/longest-common-prefix/submissions/1625388347/"/>
/// </summary>
public class Solution 
{    
    public string LongestCommonPrefix(string[] strs) 
    {
        ReadOnlySpan<char> first_chars = strs[0].AsSpan();

        for (int i = 0; i < first_chars.Length; i++)
        {
            foreach (string s in strs[1..])
            {
                ReadOnlySpan<char> chars = s.AsSpan();
                if (i == s.Length || chars[i] != first_chars[i])
                {
                    return new string(first_chars[0..i]);
                }
            }
        }

        return strs[0];
    }
}