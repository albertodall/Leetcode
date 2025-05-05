namespace Leetcode.CSharp.DecompressRLEList;

/// <summary>
/// <see cref="https://leetcode.com/problems/decompress-run-length-encoded-list/"/>
/// Results: <see cref="https://leetcode.com/problems/decompress-run-length-encoded-list/submissions/1626179460/"/>
/// </summary>
public class Solution 
{
    public int[] DecompressRLElist(int[] nums) 
    {
        if (nums.Length == 0 || nums.Length % 2 != 0)
        {
            return nums;
        }

        var result = new List<int>();
        for (int i = 0; i < nums.Length; i += 2)
        {
            int runLength = nums[i];
            int item = nums[i + 1];
            for (int j = 0; j < runLength; j++)
            {
                result.Add(item);
            }
        }
  
        return result.ToArray();
    }
}