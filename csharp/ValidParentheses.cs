namespace Leetcode.CSharp.ValidParentheses;

/// <summary>
/// <see cref="https://leetcode.com/problems/valid-parentheses/"/>
/// Results: <see cref="https://leetcode.com/problems/valid-parentheses/submissions/1625360322/"/>
/// </summary>
public class Solution 
{
    public bool IsValid(string s) 
    {
        char[] chars = s.ToCharArray();
        Stack<char> brackets = new();

        for (int i = 0; i < chars.Length; i++)
        {
            switch (chars[i])
            {
                case '(':
                    brackets.Push(')');
                    break;
                case '[':
                    brackets.Push(']');
                    break;
                case '{': 
                    brackets.Push('}');
                    break;
                case ')':
                case ']':
                case '}':
                    if (brackets.TryPeek(out char par) && par == chars[i])
                    {
                        brackets.Pop();
                    }
                    else 
                    {
                        return false;
                    }
                    break;
            }
        }

        return brackets.Count == 0;
    }
}