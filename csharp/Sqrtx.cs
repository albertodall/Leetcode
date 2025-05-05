namespace Leetcode.CSharp.Sqrt;

/// <summary>
/// <see cref="https://leetcode.com/problems/sqrtx/"/>
/// Results: <see cref="https://leetcode.com/problems/sqrtx/submissions/1625589601/"/>
/// </summary>
public class Solution 
{
    public int MySqrt(int x) 
    {
        long start = 0;
        long end = x;
        while (start <= end)
        {
            long middle = (start + end) / 2;
            long sqr = middle * middle;
            if (sqr < x)
            {
                start = middle + 1;
            }
            else if(sqr > x)
            {
                end = middle - 1;
            }
            else 
            {
                return (int)middle;
            }
        }

        return (int)end;
    }
}