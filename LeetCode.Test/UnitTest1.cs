using System;
using Xunit;

namespace LeetCode.Test
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, new int[] { 0, 1 }, 9)]
        [InlineData(new int[] { 1,8 }, new int[] { 0, 1 }, 9)]
        [InlineData(new int[] { 3, 2, 7 }, new int[] { 1, 2 }, 9)]
        public void Test1(int[] r, int[] o, int t)
        {
            var result = Program.TwoSum(r, t);
            Assert.Equal(result, o);
        }
    }
}
