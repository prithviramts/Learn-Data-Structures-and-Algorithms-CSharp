using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class Recursion
    {
        // Recursion Examples

        #region FACTORIAL
        // Factorial with Recurision
        public static int RecursiveFactorial(int number)
        {
            if (number == 0)
                return 1;

            return number * RecursiveFactorial(number - 1);
        }

        // Factorial without recursion
        public static int IterativeFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i; // factorial = factorial * i
            }
            return factorial;
        }
        #endregion

        #region SUM OF ARRAY
        // Sum of array wihout using recursion and without having a index value
        public static int SumOfArray(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        // Sum of array without using Recursion using index value
        public static int SumOfArrayWORecursion(int[] array, int index)
        {
            if (index > array.Length)
                return 0;
            int sum = 0;
            for (int i = index; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        // Sum of array using recursion using index value
        public static int SumOfArrayWRecursion(int[] array, int index)
        {
            if (index >= array.Length)
                return 0;

            int number = array[index] + SumOfArrayWRecursion(array, index + 1);
            return number;
        }
        #endregion

        // Check array is sorted or not using recursion
        public static bool IsSorted(int[] array, int index)
        {
            if (index >= array.Length - 1)
            {
                return false;
            }
            if (array[index] <= array[index + 1])
            {
                IsSorted(array, index + 1);
            }
            return true;
        }
    }
}
