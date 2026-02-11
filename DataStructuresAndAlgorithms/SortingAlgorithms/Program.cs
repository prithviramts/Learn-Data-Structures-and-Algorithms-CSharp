using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Learning DSA

            // BubbleSort
            Sort.BubbleSortAsc(new int[] { 9, 10, -1, 3, 4, 3, 5, 1 });
            Sort.BubbleSortDesc(new int[] { 5, 10, -1, 3, 5, 10 });
            // SelectionSort
            Sort.SelectionSort(new int[] { 5, 10, -1, 3, 5, 10 });
            // InsertionSort
            Sort.InsertionSort(new int[] { 5, 10, -1, 3, 5, 10 });

            // Recursion
            Recursion.RecursiveFactorial(5);
            Recursion.IterativeFactorial(7);
            Recursion.SumOfArrayWORecursion(new int[] { 1, 2, 3, 4 }, 2);
            Recursion.SumOfArrayWRecursion(new int[] { 1, 2, 3, 4 }, 2);
            Recursion.IsSorted(new int[] { 4, 1, 3, 2 }, 0);

            // LeetCode Solver
            LeetCodeSolver.RunningSum(new int[] { 1, 2, 3, 4, 5, });
            LeetCodeSolver.RichestCustomerWealth(new int[][] { new int[] {1, 2, 3}, new int[] {4, 5}, new int[] {6, 7, 8}});
            LeetCodeSolver.RichestCustomerWealthForLoop(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8 } });
            Console.WriteLine(LeetCodeSolver.FizzBuzz(20));
            Console.WriteLine(LeetCodeSolver.FizzBuzzStr(15));
        }
    }
}
