using SortingAlgorithms.LeetCodeQuest.Array1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SortingAlgorithms.LeetCodeSolver;

namespace SortingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Learning DSA
            int[] input = new int[] { 9, 10, -1, 3, 4, 3, 5, 1 };

            #region Sorting

            // BubbleSort
            Sort.BubbleSortAsc(input);
            Sort.BubbleSortDesc(input);
            // SelectionSort
            Sort.SelectionSort(input);
            // InsertionSort
            Sort.InsertionSort(input);
            // MergeSort
            Sort.MergeSort_EngSpock(input);
            Sort.MergeSort_BroCode(input);
            // QuickSort
            Sort.QuickSort_EngSpock(input);
            Sort.QuickSort_BroCode(input);

            #endregion

            #region Recursion

            // Recursion
            Recursion.RecursiveFactorial(5);
            Recursion.IterativeFactorial(7);
            Recursion.SumOfArrayWORecursion(input, 2);
            Recursion.SumOfArrayWRecursion(input, 2);
            Recursion.IsSorted(input, 0);

            #endregion

            #region LeetCode Solver

            // LeetCode Solver
            LeetCodeSolver.RunningSum(input);
            LeetCodeSolver.RichestCustomerWealth(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8 } });
            LeetCodeSolver.RichestCustomerWealthForLoop(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8 } });
            LeetCodeSolver.FizzBuzz(20);
            LeetCodeSolver.FizzBuzzStr(15);

            LeetCodeSolver.NumberOfSteps(0);

            ListNode head = BuildList(input);
            LeetCodeSolver.MiddleNote(head);

            LeetCodeSolver.TwoSum(new int[] { 3, 3 }, 6);
            LeetCodeSolver.IsPalindrome(-121);

            LeetCodeSolver.SingleNumber(new int[] { 4, 1, 2, 4, 2 });
            LeetCodeSolver.MaxProfit(new int[] { 7, 3, 1, 5, 8, 6 });
            LeetCodeSolver.ContainsDuplicate(new int[] { 7, 3, 1, 5, 8, 6, });
            LeetCodeSolver.MoveZeros(new int[] { 1, 0, 2, 3, 0, 12, 0, 3 });

            LeetCodeSolver.MissingNumber(new int[] { 9, 1, 7, 3, 6, 2, 5, 0, 4 });
            LeetCodeSolver.MissingNumberMath(new int[] { 9, 1, 7, 3, 6, 2, 5, 0, 4 });

            LeetCodeSolver.RemoveDups(new int[] { 0, 0, 1, 2, 2, 2, 3, 4, 4, 5, 5 });

            LeetCodeSolver.PivotElement(new int[] { 1, 7, 3, 6, 5, 6 });
            LeetCodeSolver.PivotElementWithoutDecRightSum(new int[] { 1, 7, 3, 6, 5, 6 });
            LeetCodeSolver.SortedSquare(new int[] { -4, -1, 0, 3, 10 });
            LeetCodeSolver.Merge(new int[] { 2, 3, 1, 0 , 0, 0 }, 3, new int[] { 2, 4, 6 }, 3);
            LeetCodeSolver.ProductExceptSelf(new int[] { 1, 2, 3, 4, 5 });
            LeetCodeSolver.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });

            LeetCodeSolver.RemoveElement(new int[] { 2 }, 3);
            LeetCodeSolver.RemoveElementOpt(new int[] {3, 3}, 3 );

            LeetCodeSolver.SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
            LeetCodeSolver.PlusOne(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });
            LeetCodeSolver.PlusOneOpt(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 });

            #endregion

            #region Hackerrank Probs

            // Hackerrank Probs
            HackerrankSEPrep.countRespTimeReg([100, 200, 150, 300]);

            #endregion

            #region LeetCode Quest - Array

            QuestArrayI.GetConcatenation(new int[] { 1, 2, 3 });

            QuestArrayI.shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);

            QuestArrayI.FindMaxConsecutiveOnes(new int[] { 0 });

            QuestArrayI.FindMaxConsecutiveOnesOpt(new int[] { 1, 1, 0, 1, 1, 1 });

            #endregion
        }
    }
}
