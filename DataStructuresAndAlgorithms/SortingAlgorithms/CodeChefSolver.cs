using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public class CodeChefSolver
    {
        public static void SearchEleOfArray()
        {
            string[] firstName = Console.ReadLine().Split();

            int n = int.Parse(firstName[0]);
            int target = int.Parse(firstName[1]);

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool found = false;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == target)
                {
                    found = true;
                }
            }
            Console.WriteLine(found ? "YES" : "NO");
        }
    }
}
