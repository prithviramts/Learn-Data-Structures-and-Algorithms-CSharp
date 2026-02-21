using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace SortingAlgorithms
{
    public class HackerrankSEPrep
    {
        #region Count elements greater than previous average

        // My logic has some major flaws. Yet it solved almost 12 out of 15 test cases in hackerrank
        public static int countRespTimeReg(List<int> respTime)
        {
            int n = 0;
            int Count = 0;
            int totSum = 0;
            for (int i = 0; i < respTime.Count; i++)
            {
                if (i == 0)
                {
                    totSum += respTime[0];
                    n++;
                    continue;
                }
                else
                {
                    int AvgVal = totSum / (n);
                    if (respTime[i] > AvgVal)
                    {
                        Count++;
                    }
                    totSum += respTime[i];
                    n++;
                }
            }
            return Count;
        }

        // The precise one
        public static int GreaterThanPreviousAvg(List<int> respTime)
        {
            // Null reference check 
            if (respTime == null || respTime.Count <= 1)
            {
                return 0;
            }
            int count = 0;
            int sum = respTime[0];

            for (int i = 0; i < respTime.Count; i++)
            {
                if (respTime[i] * i > sum)
                {
                    count++;
                }
                sum += respTime[i];
            }
            return count;
        }

        #endregion

        #region Two Sum


        // this solution will work with time complexity of O(n^2)
        // But if we use hash map, we can make the time complexity O(n)
        public static List<int> findTaskforPairSlot (List<int> taskDurations, int slotLength)
        {
            for (int i = 0; i < taskDurations.Count; i++)
            {
                for (int j = 1; j < taskDurations.Count; j++)
                {
                    if (taskDurations[i] + taskDurations[j] == slotLength)
                    {
                        return [i, j];
                    }
                }
            }
            return [-1, -1];
        }

        public static List<int> findTaskForPairSlotHash(List<int> taskDurations, int slotLength)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < taskDurations.Count; i++)
            {
                int current = taskDurations[i];
                int needed = slotLength - current;

                if (map.ContainsKey(needed))
                {
                    return new List<int> { map[needed], i };
                }

                if (!map.ContainsKey(current))
                    map[current] = i;
            }
            return new List<int> { -1, -1 };
        }

        #endregion
    }
}
