namespace Leetcode.CSharp.ValidAnagram;

/// <summary>
/// <see cref="https://leetcode.com/problems/valid-anagram/"/>
/// Results: <see cref="https://leetcode.com/problems/valid-anagram/submissions/1626139339/"/>
/// </summary>
public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        Dictionary<char, int> dict_s = [];
        Dictionary<char, int> dict_t = [];

        ReadOnlySpan<char> s_chars = s.AsSpan();
        ReadOnlySpan<char> t_chars = t.AsSpan();

        for (int i = 0; i < s_chars.Length; i++)
	    {
	        dict_s.TryGetValue(s_chars[i], out int currentCount); 
            dict_s[s_chars[i]] = currentCount + 1;
	    }
	
		for (int i = 0; i < t_chars.Length; i++)
	    {
	        dict_t.TryGetValue(t_chars[i], out int currentCount); 
            dict_t[t_chars[i]] = currentCount + 1;
	    }

        return dict_s.Count == dict_t.Count && 
               dict_s.All(kv => dict_t.ContainsKey(kv.Key) && dict_t[kv.Key] == kv.Value);
    }
}