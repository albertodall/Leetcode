namespace Leetcode.CSharp.SearchIndexPosition;

/// <summary>
/// <see cref="https://leetcode.com/problems/search-insert-position/"/>
/// Results: <see cref="https://leetcode.com/problems/search-insert-position/submissions/1625593047/"/>
/// </summary>
public class Solution 
{
    public int SearchInsert(int[] nums, int target) 
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            int middle = (start + end) / 2;
            if (nums[middle] < target)
            {
                start = middle + 1;
            }
            else if (nums[middle] > target)
            {
                end = middle - 1;
            }
            else
            {
                return middle;
            }
        }
        
        return start;
    }
}