using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class LeetCodeSolver
    {
        // LEET CODE 1480
        public static int[] RunningSum(int[] nums)
        {
            int[] output = new int[nums.Length];

            int number = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                number = number + nums[i];
                output[i] = number;
            }
            Console.WriteLine(output);
            return output;
        }
    }
}
