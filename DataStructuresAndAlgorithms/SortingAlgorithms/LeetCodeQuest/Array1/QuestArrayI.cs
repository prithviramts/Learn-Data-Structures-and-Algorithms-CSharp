using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.LeetCodeQuest.Array1
{
    public class QuestArrayI
    {
        #region Concatenation of Arrays

        public static int[] GetConcatenation(int[] nums)
        {
            int n = nums.Length;
            int[] ans = new int[2 * n];

            for (int i = 0; i < n; i++)
            {
                ans[i] = nums[i];
                ans[i + n] = nums[i];
            }

            return ans;
        }

        #endregion

        #region Shuffle the Array

        public static int[] shuffle(int[] nums, int n)
        {
            int[] shuffledArr = new int[2 * n];
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                shuffledArr[k++] = nums[i];
                shuffledArr[k++] = nums[i + n];
            }

            return shuffledArr;
        }

        #endregion

        #region Max Consecutive Ones

        // I came up with this, but not an optimal solution
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int[] ansArr = new int[nums.Length];
            int count = 0;
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    count++;
                }
                else
                {
                    ansArr[k] = count;
                    count = 0;
                    k++;
                }
            }
            if (count != 0)
            {
                ansArr[k] = count;
            }
            return ansArr.Max();
        }

        public static int FindMaxConsecutiveOnesOpt(int[] nums)
        {
            int MaxCount = 0;
            int CurrCount = 0;
            for (int i = 0; i < nums.Length;  i++)
            {
                if (nums[i] == 1)
                {
                    CurrCount++;
                    MaxCount = Math.Max(MaxCount, CurrCount);
                }
                else
                {
                    CurrCount = 0;
                }
            }
            return MaxCount;
        }

        #endregion
    }
}
