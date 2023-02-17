using LeetCodeProblems.LinkedListStructure;
using LeetCodeProblems.AllProblems;
namespace LeetCodeProblems
{
    public class Program
    {
        public static void Main(string[] args){
            LinkedList linkedList = new LinkedList();
            linkedList.head= new ListNode(1);
            linkedList.head.next= new ListNode(2);
            linkedList.head.next.next = new ListNode(3);
            linkedList.head.next.next.next = new ListNode(4);
            linkedList.head.next.next.next.next = new ListNode(5);
            RemoveNthNode obj = new RemoveNthNode();
            ListNode result = obj.removeNthNode(linkedList.head,2);
            linkedList.display(result);
        }
    }
}