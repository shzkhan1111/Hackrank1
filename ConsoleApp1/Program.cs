using LanguageExt;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 1 };
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            ReverseList(head);
            Console.ReadKey();
        }
        /** Definition for singly-linked list.*/
        public static ListNode ReverseList(ListNode head)
        {
            ListNode p = null;
            while (head != null)
            {
                ListNode temp = head.next;
                head.next = p;
                p = head;
                head = temp;
                 
            }
           return p;
        }
        public class ListNode {
           public int val;
           public ListNode next;
           public ListNode(int val=0, ListNode next=null) {
               this.val = val;
               this.next = next;
           }
       }
      











    }
}
