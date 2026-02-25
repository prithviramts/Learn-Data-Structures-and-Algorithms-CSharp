using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SortingAlgorithms
{
    public class LeetCodeSolver
    {
        #region LEET CODE - 1480 Running Sum
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
        #endregion

        #region LEET CODE - 1672 Richest Customer Wealth
        // with foreach loop
        public static int RichestCustomerWealth(int[][] accounts)
        {
            int maxWealth = 0;

            foreach (int[] account in accounts)
            {
                int wealth = 0;
                foreach (int money in account)
                {
                    wealth += money;
                }

                if (maxWealth < wealth)
                {
                    maxWealth = wealth;
                }
            }
            return maxWealth;
        }

        // with for loop
        public static int RichestCustomerWealthForLoop(int[][] accounts)
        {
            int maxWealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                int wealth = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    wealth += accounts[i][j];
                }

                if (maxWealth < wealth)
                {
                    maxWealth = wealth;
                }
            }
            return maxWealth;
        }
        #endregion

        #region LEET CODE - 412 FizzBuzz

        // This is what I thought of doing, when I proposed with this leet code problem.
        // There is an another way, where we can skip checking both 3 and 5 and concat the string. 
        public static IList<string> FizzBuzz(int n)
        {
            var answer = new List<string>(n);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    answer.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    answer.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    answer.Add("Buzz");
                }
                else
                {
                    answer.Add(i.ToString());
                }
            }

            return answer;
        }

        public static IList<string> FizzBuzzStr(int n)
        {
            List<string> answer = new List<string>(n);
            for (int i = 1; i <= n; i++)
            {
                Boolean isDivisibleBy3 = i % 3 == 0;
                Boolean isDivisibleBy5 = i % 5 == 0;

                string currString = "";
                if (isDivisibleBy3)
                {
                    currString += "Fizz";
                }
                if (isDivisibleBy5)
                {
                    currString += "Buzz";
                }
                if (string.IsNullOrEmpty(currString))
                {
                    currString += i.ToString();
                }
                answer.Add(currString);
            }
            return answer;
        }

        #endregion

        #region LEET CODE - 1342 Number Of Steps

        public static int NumberOfSteps(int num)
        {
            int counter = 0;
            int oriNum = num;
            for (int i = 0; i < oriNum; i++)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    counter++;
                }
                if (num % 2 == 1)
                {
                    num = num - 1;
                    counter++;
                }
                if (num == 0)
                {
                    break;
                }
            }
            return counter;
        }

        #endregion

        #region LEET CODE - 876 Build List

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

        public static ListNode BuildList(int[] arr)
        {
            if (arr.Length == 0) return null;

            ListNode head = new ListNode(arr[0]);
            ListNode current = head;

            for (int i = 1; i < arr.Length; i++)
            {
                current.next = new ListNode(arr[i]);
                current = current.next;
            }

            return head;
        }

        public static ListNode MiddleNote(ListNode head)
        {
            ListNode middle = head;
            ListNode end = head;

            while (end != null && end.next != null)
            {
                middle = middle.next;
                end = end.next.next;
            }

            return middle;
        }

        #endregion

        #region LEET CODE - 1 Two Sum

        // Adjacent values will only be checked here. 
        public static int[] TwoSum_AdjacentOnly(int[] nums, int target)
        {
            int[] res = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    res[i] = nums[i];
                    res[i + 1] = nums[i + 1];
                }
            }

            return res;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { 0, 0 };
        }

        #endregion

        #region LEET CODE - 9 Is Palindrome

        public static bool IsPalindrome(int x)
        {
            int res = 0;
            while (x > 0)
            {
                res = (res * 10) + (x % 10);
                x /= 10;
            }
            if (res == x) return true;
            else
                return false;
        }

        #endregion

        #region LEETCODE - 136 Single Number

        public static int SingleNumber(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                res = res ^ nums[i];
            }

            return res;
        }

        #endregion

        #region LEETCODE - 121 Best Time to Buy and Sell Stock

        public static int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxprofit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    int profit = prices[i] - minPrice;
                    if (profit > maxprofit)
                        maxprofit = profit;
                }
            }
            return maxprofit;
        }

        #endregion

        #region LEETCODE - 217 Contain Duplicate

        public static bool ContainsDuplicate(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                        return true;
                }
            }
            return false;
        }

        public static bool ContainsDuplicateWithHash(int[] nums)
        {
            HashSet<int> Seen = new HashSet<int>();

            foreach (int i in nums)
            {
                if (Seen.Contains(i)) return true;

                Seen.Add(i);
            }
            return false;
        }

        #endregion

        #region LEETCODE - 283 Move Zeros

        public static void MoveZeros(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == 0)
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }

        public static void MoveZerosOptimalSoln(int[] nums)
        {
            int arrPos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[arrPos] = nums[i];
                    arrPos++;
                }
            }

            for (int i = arrPos; i < nums.Length; i++)
            {
                nums[i] = 0;
            }

        }

        #endregion

        #region LEETCODE 1295 Find Numbers with Even Numbers of Digit

        public static int FindNumbers(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();

            return 0;
        }

        #endregion

        #region LEETCODE - 268 Missing Number

        // Finding missing number by sorting 
        public static int MissingNumber(int[] nums)
        {
            int missNum = 0;
            nums.Sort();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    missNum = i;
                    break;
                }
            }
            return missNum;
        }


        // Take factorial of the nums.Length and add all the values in the nums array.
        public static int MissingNumberMath(int[] nums)
        {
            int n = nums.Length;
            int expectedSum = n * (n + 1) / 2;

            int actualSum = 0;

            for (int i = 0; i < n; i++)
            {
                actualSum += nums[i];
            }
            return expectedSum - actualSum;
        }

        #endregion

        #region LEETCODE - 26 Remove Duplicates from Sorted Array

        public static int RemoveDups(int[] nums)
        {
            int[] uniEle = new int[nums.Length];
            int UniqueVal = 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    uniEle[i] = nums[j];
                    nums[i] = nums[j];
                    UniqueVal++;
                }
            }
            return i + 1 | UniqueVal;
        }

        #endregion

        #region LEETCODE - 724 Find Pivot Index

        public static int PivotElement(int[] nums)
        {
            int totSum = 0;
            foreach (int num in nums)
            {
                totSum += num;
            }
            int leftSum = 0;
            int i = 0;
            int rightSum = totSum - leftSum - nums[i];

            for (i = 0; i < nums.Length; i++)
            {
                rightSum = totSum - leftSum - nums[i];
                if (leftSum == rightSum)
                {
                    return nums[i];
                }
                else
                {
                    leftSum += nums[i];
                }
            }
            return -1;
        }

        public static int PivotElementWithoutDecRightSum(int[] nums)
        {
            int totSum = 0;
            foreach (int num in nums)
            {
                totSum += num;
            }
            int leftSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == totSum - leftSum - nums[i])
                    return i;

                leftSum += nums[i];
            }
            return -1;
        }

        #endregion

        #region LEETCODE - 977 Squares of the sorted array

        public static int[] SortedSquare(int[] nums)
        {
            int n = nums.Length;
            int[] res = new int[n];

            int left = 0; int right = n - 1; int pos = n - 1;

            while (left <= right)
            {
                int l = nums[left] * nums[left];
                int r = nums[right] * nums[right];

                if (l > r)
                {
                    res[pos--] = l;
                    left++;
                }
                else
                {
                    res[pos--] = r;
                    right--;
                }
            }
            return res;

        }

        #endregion

        #region LEETCODE - 88 Merge Sorted Array

        public static void Merge(int[] nums1, int n, int[] nums2, int m)
        {
            for (int i = n; i < nums1.Length; i++)
            {
                nums1[i] = nums2[i - n];
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    if (nums1[i] < nums1[j])
                    {
                        int temp = nums1[i];
                        nums1[i] = nums1[j];
                        nums1[j] = temp;
                    }
                }
            }
        }

        public static void MergeOpt(int[] nums1, int n, int[] nums2, int m)
        {
            int i = n - 1;
            int j = m - 1;
            int k = n + m - 1;

            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;

            }
        }

        #endregion

        #region LEETCODE - 238 Product of Array Itself

        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] answer = new int[nums.Length];
            int leftProd = 0, rightProd = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                leftProd *= nums[i];
            }

            return answer;
        }

        #endregion

        #region LEETCODE - 41 First Missing Positive


        // I'll start with a foreach loop, and inside the foreach loop, I'll go through condition 
        // If (num == 
        public static int FirstMissingPositive(int[] nums)
        {
            int missingNum = 0;
            HashSet<int> res = new HashSet<int>();
            foreach (int num in nums)
            {
                //if ()
                //{
                //    res.Add(num);
                //}
                missingNum = num;
            }
            return missingNum;
        }

        #endregion

        #region LEETCODE - 14 Longest Common Prefix

        public static string LongestCommonPrefix(string[] strs)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                //if (strs[i] == strs[i+1])
                //{
                //    return strs[i];
                //}
            }

            return "";
        }

        #endregion

        #region LEETCODE - 27 Remove Element


        // Over complicated Noob solution
        public static int RemoveElement(int[] nums, int val)
        {
            int n = nums.Length;
            int wall = n - 1;

            for (int i = 0; i < n; i++)
            {
                if (i < wall)
                {
                    if (nums[i] == val)
                    {
                        if (nums[wall] == val)
                        {
                            int tempI = nums[wall - 1];
                            nums[wall - 1] = nums[i];
                            nums[i] = tempI;
                        }
                        else
                        {
                            int temp = nums[wall];
                            nums[wall] = nums[i];
                            nums[i] = temp;
                        }
                        wall--;
                    }
                }
            }
            return wall;
        }

        // Optimal solution
        public static int RemoveElementOpt(int[] nums, int val)
        {
            int n = nums.Length;
            int i = 0;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    n--;
                }
                else
                {
                    i++;
                }
            }
            return n;
        }

        #endregion

        #region LEETCODE - 35 Search Insert Position

        public static int SearchInsert(int[] nums, int target)
        {
            int n = nums.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] < target)
                {
                    count++;
                }
            }
            return count;

        }

        #endregion

        #region LEETCODE - 66 Plus One

        // this will work for small int value, even long can't give the values more than 999999999. so below solution is optimal
        public static int[] PlusOne(int[] digits)
        {
            int digLen = digits.Length;
            int wholeNum = 0;
            List<int> resList = new List<int>();
            for (int i = 0; i < digLen; i++)
            {
                wholeNum = wholeNum * 10 + digits[i];
            }
            wholeNum++;

            while (wholeNum >= 1)
            {
                int dig = 0;
                dig = wholeNum % 10;
                wholeNum /= 10;
                resList.Add(dig);
            }

            int[] resArr = resList.ToArray();
            int len = resArr.Length - 1;
            for (int i = 0; i <= len; i++)
            {
                int temp = resArr[i];
                resArr[i] = resArr[len];
                resArr[len] = temp;
                len--;
            }
            
            return resArr;
        }

        public static int[] PlusOneOpt(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }

            int[] result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }

        #endregion
    }
}
