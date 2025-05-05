namespace Leetcode.CSharp.TwoSum;

/// <summary>
/// <see cref="https://leetcode.com/problems/two-sum/"/>
/// Results: <see cref="https://leetcode.com/problems/two-sum/submissions/1624752942/"/>
/// </summary>
public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (dict.ContainsKey(diff)) 
            {
                return [dict[diff], i];
            }
            else
            {
                dict[nums[i]] = i;
            }
        }

        return [0, 0];
    }
}