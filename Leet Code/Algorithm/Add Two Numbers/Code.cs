public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        this.next = null;
    }
    public ListNode(int x, ListNode n)
    {
        val = x;
        next = n;
    }

    static ListNode addTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = null;
        string f = "";
        while(l1 != null)
        {
            f += l1.val.ToString();
            l1 = l1.next;
        }

        string s = string.Empty;
        while(l2 != null)
        {
            s += l2.val.ToString();
            l2 = l2.next;
        }

        string maxS = f.Length >= s.Length ? f : s;
        string minS = f.Length >= s.Length ? s : f;
        int minLength = minS.Length;
        string sum = "";
        int remainder = 0;
        for (int i = 0; i < maxS.Length; i++)
        {
            int n1 = Convert.ToInt32(maxS.Substring(i, 1));
            if (i < minLength || remainder > 0)
            {
                int n2 = 0;
                if (i < minLength)
                {
                    n2 = Convert.ToInt32(minS.Substring(i, 1));
                }
                
                string subSum = (n1 + n2 + remainder).ToString();
                if (subSum.Length > 1)
                {
                    sum = subSum.Substring(1, 1) + sum;
                    remainder = Convert.ToInt32(subSum.Substring(0, 1));
                }
                else
                {
                    sum = subSum + sum;
                    remainder = 0;
                }                    
            }
            else
                sum = maxS.Substring(i, 1) + sum;
        }
        if(remainder > 0)
        {
            sum = remainder.ToString() + sum;            
        }


        for (int i = 0; i < sum.Length; i++)
        {
            int val = Convert.ToInt32(sum.Substring(i, 1));
            var node = new ListNode(val);
            if (result == null)
                result = node;
            else
                node.next = result;
            result = node;
        }

        return result;
    }
}
