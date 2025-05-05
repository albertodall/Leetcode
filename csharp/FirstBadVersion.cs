namespace Leetcode.CSharp.FirstBadVersion;

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

/// <summary>
/// Stub class.
/// </summary>
public class VersionControl
{
    protected bool IsBadVersion(int version) 
    {
        // The isBadVersion API is defined in the parent class VersionControl
        return true;
    }
}

/// <summary>
/// <see cref="https://leetcode.com/problems/first-bad-version/"/>
/// Results: <see cref="https://leetcode.com/problems/first-bad-version/submissions/1625601146/"/>
/// </summary>
public class Solution : VersionControl 
{
    public int FirstBadVersion(int n) 
    {
        int start = 1;
        int end = n;
        
        while (start < end)
        {
            int version = start + (end - start) / 2;
            if (IsBadVersion(version))
            {
                end = version;
            }
            else 
            {
                start = version + 1;
            }
        }

        return start;
    }
}

