namespace Leetcode.CSharp.PlusOne;

/// <summary>
/// <see cref="https://leetcode.com/problems/plus-one/"/>
/// </summary>
public class Solution 
{
    public int[] PlusOne(int[] digits) 
    {
        long number = 0;
        for (int i = 0; i < digits.Length; i++)
		{
    		number += digits[i] * (long)Math.Pow(10, digits.Length - 1 - i);
		}

		number++;
        
        List<int> digitsList = [];
        for (; number != 0; number /= 10)
        {
			digitsList.Add((int)(number % 10));
        }

        int[] result = [.. digitsList];	
        Array.Reverse(result);
        return result;
    }
}