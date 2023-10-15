public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class AddTwoNumbersTask
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        var result = new ListNode();
        var curr = result;
        var remains = 0;

        while (l1 != null || l2 != null) 
        {
            var sum = remains;
            
            if (l1 != null) 
            {
                sum += l1.val;
                l1 = l1.next;
            }
            
            if (l2 != null) 
            {
                sum += l2.val;
                l2 = l2.next;
            }
            
            remains = sum / 10;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
        }
        
        if (remains != 0)
            curr.next = new ListNode(remains);

        return result.next;
    }
}