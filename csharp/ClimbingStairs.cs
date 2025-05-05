namespace Leetcode.CSharp.ClimbingStairs;

/// <summary>
/// <see cref="https://leetcode.com/problems/climbing-stairs/"/>
/// </summary>
public class Solution 
{
    public int ClimbStairs(int n) 
    {
        return n > 2 ? ClimbStairs(n - 1) + ClimbStairs(n - 2) : n;
    }
}