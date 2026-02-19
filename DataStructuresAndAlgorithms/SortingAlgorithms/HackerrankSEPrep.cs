using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class HackerrankSEPrep
    {
        public static int countRespTimeReg(List<int> respTime)
        {
            int n = respTime.Count;
            int Count = 0;
            int[] avgItemList = new int[n];
            avgItemList[0] = respTime[0];
            for(int i = 0; i < n; i++)
            {
                if(respTime[i] > AvgFunc(avgItemList)) 
                {
                    Count++;
                    avgItemList[i] = respTime[i];

                }
            }
            return Count;

            int AvgFunc(int[] avgItemList)
            {
                int n = avgItemList.Length;
                int totSum = 0;
                foreach (int num in avgItemList)
                {
                    totSum += num;
                }
                return totSum / n;
            }
        }
    }
}
