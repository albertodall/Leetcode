namespace Leetcode.CSharp.SingleNumber;

/// <summary>
/// <see cref="https://leetcode.com/problems/single-number/"/>
/// Results: <see cref="https://leetcode.com/problems/single-number/submissions/1626124520/"/>
/// </summary>
public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        return nums.Aggregate((n1, n2) => n1 ^ n2);
    }
}