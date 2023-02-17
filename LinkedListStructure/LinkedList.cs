using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.LinkedListStructure
{
    public class ListNode
    {
        public int data;
        public ListNode next;
        public ListNode(int val){
            this.data=val;
            this.next= null;
        }
    }
    public class LinkedList{
        public ListNode head;
        public LinkedList(){
            this.head = null;
        }
        public ListNode getHead(){
            return head;
        }

        public void display(ListNode head){
            ListNode curr = head;
            while (curr != null){
                if(curr.next != null){
                    Console.Write(curr.data);
                    Console.Write("->");
                }
                else{
                    Console.Write(curr.data);
                }
                curr = curr.next;
            }
        }
    }


}