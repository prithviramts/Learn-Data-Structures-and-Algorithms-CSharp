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

            // LeetCode Solver
            RunningSumOf1DArray.RunningSum(new int[] { 1, 2, 3, 4, 5, });
        }
    }
}
