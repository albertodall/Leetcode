namespace Leetcode.CSharp.BinarySearch;

/// <summary>
/// <see cref="https://leetcode.com/problems/binary-search/"/>
/// Results: <see cref="https://leetcode.com/problems/binary-search/submissions/1626299738/"/>
/// </summary>
public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            int middle = start + (end - start) / 2;
            if (nums[middle] == target)
            {
                return middle;
            }
            else if (nums[middle] > target)
            {
                end = middle - 1;
            }
            else
            {
                start = middle + 1;
            }
        }

        return -1;
    }
}