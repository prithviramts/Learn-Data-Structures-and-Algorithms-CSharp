using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public class CodeChefSolver
    {
        // Sample input 
        // 5 3
        // 1 2 4 3 8
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

        // Sample Input
        // 1
        // 5
        // 3 4 1 8 6
        public static void FindMaximumInArray()
        {
            int testCase = int.Parse(Console.ReadLine()); // 1

            for (int t = 0; t < testCase; t++)
            {
                int Range = int.Parse(Console.ReadLine()); // 5

                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 3 4 7 1 2

                int MaxValue = arr[0];

                for (int i = 0; i < Range; i++)
                {
                    if (MaxValue < arr[i])
                    {
                        MaxValue = arr[i];
                    }
                }

                Console.WriteLine(MaxValue);
            }
        }

        // Sample Input
        //5
        //4 30 10
        //15 8 22 6
        //4 40 10
        //15 8 22 6
        //4 34 10
        //15 8 22 6
        //2 10 100
        //60 80
        //3 30 5
        //50 60 50
        public static void TakeDiscOrNot()
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCases; t++)
            {
                string[] firstLine = Console.ReadLine().Split();
                int n = int.Parse(firstLine[0]);
                int x = int.Parse(firstLine[1]);
                int y = int.Parse(firstLine[2]);
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int TotValue = 0;
                int TotValueAftDis = 0;
                for (int i = 0; i < n; i++)
                {
                    TotValue += arr[i];
                    int priceAmtAftDis = arr[i] - y;
                    if (priceAmtAftDis > 0)
                    {
                        TotValueAftDis += priceAmtAftDis;
                    }
                    else
                    {
                        TotValueAftDis += 0;
                    }
                }
                TotValueAftDis += x;
                if (TotValue > TotValueAftDis)
                {
                    Console.WriteLine("COUPON");
                }
                else
                {
                    Console.WriteLine("NO COUPON");
                }
            }
        }
    }
}
