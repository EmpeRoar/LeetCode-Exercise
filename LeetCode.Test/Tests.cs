using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode.Test
{
    /// <summary>
    /// Tests
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// Testing Two Sum
        /// </summary>
        /// <param name="r"></param>
        /// <param name="o"></param>
        /// <param name="t"></param>
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, new int[] { 0, 1 }, 9)]
        [InlineData(new int[] { 1,8 }, new int[] { 0, 1 }, 9)]
        [InlineData(new int[] { 3, 2, 7 }, new int[] { 1, 2 }, 9)]
        public void TwoSumTest(int[] r, int[] o, int t)
        {
            var result = Program.TwoSum(r, t);
            Assert.Equal(result, o);
        }

        [Theory]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, 
                    new int[] { 9, 9, 9, 9 }, 
                    new int[] { 8, 9, 9, 9, 0, 0, 0, 1 },
                    "89990001")]
        [InlineData(new int[] { 2, 4, 3 },
                    new int[] { 5, 6, 4 },
                    new int[] { 7, 0, 8 },
                    "708")]
        [InlineData(new int[] { 2, 4, 9 },
                    new int[] { 5, 6, 4, 9 },
                    new int[] { 7, 0, 4, 0, 1},
                    "70401")]
        public void TestAddTwoNumbers(int[] p1, int[] p2, int[] expected, string expectedStr)
        {
            var l1 = Program.ArrayToLinkedList(p1);
            var l2 = Program.ArrayToLinkedList(p2);
            var result = Program.AddTwoNumbers(l1, l2);
            List<int> tr = new List<int>();
            (ListNode n, List<int> l) r = Program.traverse(result, tr);
            var ROutput = r.l.ToArray();
            var RExpected = expected;
            Assert.Equal(ROutput, RExpected);
            Assert.Equal(expectedStr, String.Join("", ROutput));
        }
    }
}
