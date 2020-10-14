using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
           

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i <= nums.Count(); i++)
            {
                for (int j = 1; j < nums.Count(); j++)
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
