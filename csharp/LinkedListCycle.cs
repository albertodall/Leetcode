namespace Leetcode.CSharp.LinkedListCycle;

// Definition for singly-linked list.
public class ListNode 
{
    public int val;
    public ListNode? next;
    public ListNode(int x) 
    {
        val = x;
        next = null;
    }
}

/// <summary>
/// <see cref="https://leetcode.com/problems/linked-list-cycle/"/>
/// Results: <see cref="https://leetcode.com/problems/linked-list-cycle/submissions/1626316338/"/> 
/// </summary>
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode fast = head;
        while (fast is not null && fast.next is not null)
        {
            head = head.next;
            fast = fast.next.next;
            if (head.Equals(fast))
            {
                return true;
            }
        }

        return false;
    }
}
