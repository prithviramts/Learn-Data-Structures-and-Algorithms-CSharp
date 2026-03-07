using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class LeetCodeSolverMed
    {
        // Prefix Sum

        #region 560. Subarray Sum Equals K

        public static int SubArraySum(int[] nums, int k) // [1, 1, 1] , 2
        {
            int prefixSum = 0;
            int count = 0;
            Dictionary<int, int> prefixSumFreq = new Dictionary<int, int>();

            prefixSumFreq.Add(0, 1);

            foreach (int num in nums) // iteration 1: num - 1, prefix sum - 0 
            {
                prefixSum += num; // prefixSum = 1

                if (prefixSumFreq.ContainsKey(prefixSum - k))
                {
                    count += prefixSumFreq[prefixSum - k];
                }

                if (prefixSumFreq.ContainsKey(prefixSum))
                {
                    prefixSumFreq[prefixSum]++;
                }
                else
                {
                    prefixSumFreq[prefixSum] = 1;
                }
            }
            return count;
        }

        #endregion

        #region 525. Contiguous Array



        #endregion

        #region 523. Continuous SubArray Sum 



        #endregion

        #region 974. Subarray Sums Divisible by K



        #endregion

        #region 238. Product of Array except Self



        #endregion

        #region 437. Path Sum III



        #endregion

        // Two Pointers

        #region 167. Two Sum II - Input Array is Sorted

        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0; int right = numbers.Length - 1;

            while (left < right)
            {
                int total = numbers[left] + numbers[right];
                if (total == target)
                {
                    return [left + 1, right + 1];
                }
                if (total < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return [0, 0];
        }
        #endregion

        #region 15. 3Sum



        #endregion

        #region 11. Container with most water

        public static int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int width = right - left;
                int minHeight = Math.Min(height[left], height[right]);
                int area = minHeight * width;

                maxArea = Math.Max(maxArea, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }


        #endregion

        // Sliding Window

        //easy
        #region 643. Maximum Average SubArray I

        #endregion

        //medium
        #region 3. Longest Substring without Repeating Characters

        #endregion

        //hard - move it to the hard Leetcodefile once its created
        #region 76. Minimum Window Substring


        #endregion

        // FAST AND SLOW POINTERS PATTERN (A VARIANT OF TWO POINTERS)

        #region 141. Linked List Cycle

        #endregion

        #region 202. HappyNumber

        #endregion

        #region 287. Find the Duplicate Number


        #endregion


        // LINKED LIST IN-PLACE REVERSAL PATTERN

        #region 206. Reverse Linked List


        #endregion

        #region 92. Reverse linked list II


        #endregion

        #region 24. Swap Nodes in Pairs


        #endregion

        // MONOTONIC STACK

        // easy
        #region 496. Next greater element

        #endregion

        // Medium
        #region 739. Daily Temperatures

        #endregion

        // Hard
        #region 84. Largest Rectangle in Histogram


        #endregion

        // Top K elements Patterns

        #region 215. Kth Largest Element in an Array


        #endregion

        #region 347. Top K-Frequent Element

        #endregion

        #region 373. Find K Pairs with Smallest Sums


        #endregion

        // Overlapping Intervals

        #region 56. Merge Intervals

        #endregion

        #region 57. Insert Intervals

        #endregion

        #region 435. Non-overlapping intervals 

        #endregion

        // Modified Binary Search 

        #region 33. Search in Rotated Sorted Array

        #endregion

        #region 153. Find minimum in Rotated Sorted Array

        #endregion

        #region 240. Search a 2D matrix

        #endregion

        // BINARY TREE TRAVERSAL

        // 4 popular ways to traverse a binary tree are
        // Pre-Order: root -> left -> right
        // In-Order: left -> root -> right
        // Post-Order: left -> right -> root
        // Level-Order: Level by level


        #region (Pre-Order) 257. Binary Tree Paths

        #endregion

        #region (In-Order) 230. Kth Smallest Element in BST

        #endregion

        #region (Post-Order) 124. Binary Tree Maximum Path Sum

        #endregion

        #region (Level-Order) 107. Binary Tree Level Order Traversal II

        #endregion

        // DEPTH-FIRST SEARCH (DFS)

        #region 133. Clone Graph

        #endregion

        #region 113. Path Sum II

        #endregion

        #region Course Schedule II

        #endregion

        // Breadth-First Search (BFS)

        #region 102. Binary Tree Level Order Traversal

        #endregion

        #region 994. Rotting Oranges

        #endregion

        // Hard
        #region 127. Word Ladder    

        #endregion

        // MATRIX TRAVERSAL

        #region 733. Flood fill

        #endregion

        #region 200. Number of Islands

        #endregion

        #region 130. Surround Regions

        #endregion

        // BackTracking

        #region 46. Permutations

        #endregion

        #region 78. SubSets

        #endregion

        #region 51. N-Queens

        #endregion

        // Dynamic Programming
        // Common DP patterns 
        // 1. Fibonacci Numbers
        // 2. 0/1 Knapsack
        // 3. Longest Common Subsequence (LCS)
        // 4. Longest Increasing Subsequence (LIS)
        // 5. Subset Sum
        // 6. Matrix Chain Multiplication

        // Easy
        #region 70. Climbing chairs

        #endregion

        #region 300. Longest Increasing Subsequence

        #endregion

        #region 322. Coin Change

        #endregion

        #region 416. Partition Equal Subset Sum

        #endregion

        #region 1143. Longest Common Subsequence

        #endregion

        // Hard
        #region 312. Bursting Balloons

        #endregion
    }
}
