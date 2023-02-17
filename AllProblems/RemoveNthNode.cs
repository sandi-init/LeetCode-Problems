using LeetCodeProblems.LinkedListStructure;

namespace LeetCodeProblems.AllProblems
{
    public class RemoveNthNode
    {
        public ListNode removeNthNode(ListNode head, int n){
            ListNode slowPtr = head;
            ListNode fastPtr = head;
            int pos =0;
            while (slowPtr != null){
                slowPtr = slowPtr.next;
                if (pos > n){
                    fastPtr = fastPtr.next;
                }
                pos += 1;
            }
            if(pos == n){
                return head.next;
            }
            fastPtr.next = fastPtr.next.next;
            return head;
        }
    }
}