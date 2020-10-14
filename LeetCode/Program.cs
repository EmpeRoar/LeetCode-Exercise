using System;
using System.Linq;

namespace LeetCode
{
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
    
    
    }
}
