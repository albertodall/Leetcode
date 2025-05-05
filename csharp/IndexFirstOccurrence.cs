namespace Leetcode.CSharp.IndexFirstOccurrence;

/// <summary>
/// <see cref="https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/"/>
/// Results: <see cref="https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/submissions/1625395726/"/>
/// </summary>
public class Solution 
{
    public int StrStr(string haystack, string needle) 
    {
        return haystack.AsSpan().IndexOf(needle.AsSpan());
    }
}