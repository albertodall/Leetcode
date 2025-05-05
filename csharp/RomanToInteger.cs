namespace Leetcode.CSharp.RomanToInt;

/// <summary>
/// <see cref="https://leetcode.com/problems/roman-to-integer/"/>
/// Results: <see cref="https://leetcode.com/problems/roman-to-integer/submissions/1625580398/"/>
/// </summary>
public class Solution 
{
    public int RomanToInt(string s) 
    {
        Dictionary<char, int> romans = new()
        {
            { 'I',    1 },
            { 'V',    5 },
            { 'X',   10 },
            { 'L',   50 },
            { 'C',  100 },
            { 'D',  500 },
            { 'M', 1000 }
        };

        int result = 0;
        var chars = s.AsSpan();
        for (int i = 0; i < chars.Length - 1; i++)
        {
            if (romans[chars[i]] < romans[chars[i + 1]])
            {
                result -= romans[chars[i]];
            }
            else
            {
                result += romans[chars[i]];
            }
        }

        return result + romans[chars[^1]];
    }
}