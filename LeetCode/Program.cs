using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
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

    public class Program
    {

        static void Main(string[] args)
        {
           

        }

        /// <summary>
        /// TwoSum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i <= nums.Count(); i++)
            {
                for (int j = i + 1; j < nums.Count(); j++)
                {
                    if (target == (nums[i] + nums[j]))
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    
    
        /// <summary>
        /// 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            List<int> l1r = new List<int>(), l2r = new List<int>();
            (ListNode n, List<int> l) r1 = traverse(l1, l1r);
            (ListNode n, List<int> l) r2 = traverse(l2, l2r);
            var r1d = ToDigit(r1.l);
            var r2d = ToDigit(r2.l);
            var total = r1d + r2d;
            return ToLinkedList(total);
        }

        public static ListNode ToLinkedList(int digit)
        {
            var strDigit = digit.ToString();
            var cr = strDigit.ToCharArray();
            ListNode n = new ListNode(GetNumericValue(cr[0]));
            for(var i = 1; i < cr.Length; i++)
                n = new ListNode(GetNumericValue(cr[i]), n);
            return n;
        }

        public static (ListNode, List<int>) traverse(ListNode n, List<int> lr)
        {
            lr.Add(n.val);
            if (n.next != null)
                traverse(n.next, lr);
            return (n, lr);
        }

        public static int GetNumericValue(char c) =>
            (int) Char.GetNumericValue(c);
        public static int ToDigit(List<int> l) => 
            Int32.Parse(String.Join("", l.ToArray()));


        public static ListNode ArrayToLinkedList(int[] r)
        {
            ListNode ll = new ListNode(r[0]);
            for (int i = 1; i < r.Length; i++)
                ll = new ListNode(r[i], ll);
            return ll;
        }

    }
}
