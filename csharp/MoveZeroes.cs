namespace Leetcode.CSharp.MoveZeroes;

/// <summary>
/// <see cref="https://leetcode.com/problems/move-zeroes/"/>
/// Results: <see cref="https://leetcode.com/problems/move-zeroes/submissions/1626132909/"/>
/// </summary>
public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        if (nums.Length > 1)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int swap = nums[k];
                    nums[k] = nums[i];
                    nums[i] = swap;
                    k++;
                }
            }
        }
    }
}