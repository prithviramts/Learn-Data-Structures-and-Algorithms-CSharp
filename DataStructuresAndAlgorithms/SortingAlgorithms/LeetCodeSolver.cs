using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class LeetCodeSolver
    {
        #region LEET CODE - 1480
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
        
        #region LEET CODE - 1672
        // with foreach loop
        public static int RichestCustomerWealth(int[][] accounts)
        {
            int maxWealth = 0;

            foreach(int[] account in accounts)
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

            for(int i = 0; i < accounts.Length; i++)
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

        #region LEET CODE - 412

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
    }
}
