namespace Leetcode.CSharp.HappyNumber;

/// <summary>
/// <see cref="https://leetcode.com/problems/happy-number/"/>
/// Results: <see cref="https://leetcode.com/problems/happy-number/submissions/1626342365/"/>
/// </summary>
public class Solution 
{
    public bool IsHappy(int n) 
    {
        HashSet<int> set = [];

        while (n != 1)
        {
            if (set.Contains(n))
            {
                return false;
            }
            set.Add(n);

            int sumSquares = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sumSquares += digit * digit;
                n /= 10;
            }
            n = sumSquares;
        }
        return true;
    }
}