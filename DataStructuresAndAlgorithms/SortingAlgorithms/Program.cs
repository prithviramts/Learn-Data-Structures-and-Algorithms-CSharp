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

            // Recursion
            Recursion.RecursiveFactorial(5);
            Recursion.IterativeFactorial(7);
            Recursion.SumOfArrayWORecursion(input, 2);
            Recursion.SumOfArrayWRecursion(input, 2);
            Recursion.IsSorted(input, 0);

            // LeetCode Solver
            LeetCodeSolver.RunningSum(input);
            LeetCodeSolver.RichestCustomerWealth(new int[][] { new int[] {1, 2, 3}, new int[] {4, 5}, new int[] {6, 7, 8}});
            LeetCodeSolver.RichestCustomerWealthForLoop(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8 } });
            LeetCodeSolver.FizzBuzz(20);
            LeetCodeSolver.FizzBuzzStr(15);

            LeetCodeSolver.NumberOfSteps(0);

            ListNode head = BuildList(input);
            LeetCodeSolver.MiddleNote(head);
        }
    }
}
