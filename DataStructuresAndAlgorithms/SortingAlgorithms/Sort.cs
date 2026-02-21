using System.Collections.Concurrent;

namespace SortingAlgorithms
{
    public class Sort
    {
        public static void BubbleSortAsc(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void BubbleSortDesc(int[] array)
        {
            for (int partIndex = 0; partIndex < array.Length - 1; partIndex++)
            {
                for (int i = array.Length - 1; i > partIndex; i--)
                {
                    if (array[i] > array[i - 1])
                    {
                        Swap(array, i, i - 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int LargestAt = 0;
                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[LargestAt])
                    {
                        LargestAt = i;
                    }
                }
                Swap(array, LargestAt, partIndex);
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int partIndex = 1; partIndex < array.Length; partIndex++)
            {
                int curUnsorted = array[partIndex];
                int i = 0;
                for (i = partIndex; i > 0 && array[i - 1] > curUnsorted; i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = curUnsorted;
            }
        }


        #region ShellSort

        public static void ShellSortEngineeringSpokMeth(int[] array)
        {
            int gap = 1;
            while (gap > array.Length / 3)
            {
                gap = 3 * gap;
            }
        }

        public static void ShellSortJennysMeth(int[] array)
        {

            for (int gap = array.Length / 2; gap >= 1; gap++)
            {
                for (int j = gap; j < array.Length; j++)
                {
                    for(int i = j - gap;  i >= 0; i-=gap )
                    {
                        if (array[i] < array[j])
                        {
                            Swap(array, i, j);
                        }
                    }
                }
            }
        }

        #endregion


        #region MergeSort

        public static void MergeSort_EngSpock(int[] array)
        {
            int[] aux = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low) return;
                
                int mid = (low + high) / 2;
                Sort(low, mid); //l
                Sort(mid + 1, high);  //r
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1])
                    return;
                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, high - low + 1);

                for (int k = low; k < high; k++)
                {
                    if (i > mid) array[k] = array[i++];
                    else if (j > high) array[k] = array[i++];
                    else if (aux[j] < aux[i])
                        array[k] = aux[j++];
                    else
                        array[k] = aux[i++];
                }
            }
        }

        public static void MergeSort_BroCode(int[] array) // 3 4 1 4 6 5 6 7
        {
            int length = array.Length;
            if (length <= 1) return;

            int middle = length / 2;
            int[] leftArr = new int[middle];
            int[] rightArr = new int[length - middle];

            int i = 0; //left array 
            int j = 0; //right array
            for (; i < length; i++)
            {
                if (i < middle)
                {
                    leftArr[i] = array[i];
                }
                else
                {
                    rightArr[j] = array[i];
                    j++;
                }
            }
            MergeSort_BroCode(leftArr);
            MergeSort_BroCode(rightArr);
            merge(leftArr, rightArr, array);

            static void merge(int[] leftArr, int[] rightArr, int[] array)
            {
                int leftSize = array.Length / 2;
                int rightSize = array.Length - leftSize;

                int i = 0, l = 0, r = 0;
                while (l < leftSize && r < rightSize)
                {
                    if (leftArr[l] < rightArr[r])
                    {
                        array[i] = leftArr[l];
                        i++;
                        l++;
                    }
                    else
                    {
                        array[i] = rightArr[r];
                        i++;
                        r++;
                    }
                }
                while (l < leftSize)
                {
                    array[i] = leftArr[l];
                    i++;
                    l++;
                }
                while (r <  rightSize)
                {
                    array[i] = rightArr[r];
                    i++;
                    r++;
                }
            }
        }

        #endregion

        public static void QuickSort_EngSpock(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low) return;

                int j = Partition(low, high);
                Sort(low, j - 1);
                Sort(j + 1, high);
            }

            int Partition(int low, int high)
            {
                int i = low;
                int j = high + 1;

                int pivot = array[low];
                while (true)
                {
                    while (array[++i] < pivot)
                    {
                        if (i == high ) break;
                    }
                    while (pivot < array[--j])
                    {
                        if (j == low) break;
                    }

                    if (i >= j) break;
                    Swap(array, i, j);
                }
                Swap(array, low, j);
                return j;
            }
        }

        public static void QuickSort_BroCode(int[] array)
        {
            quickSort(array, 0, array.Length - 1);

            void quickSort(int[] array, int start, int end)
            {
                if (end <= start) return;

                int pivot = partition(array, start, end);
                quickSort(array, start, pivot - 1);
                quickSort(array, pivot + 1, end);

            }

            int partition(int[] array, int start, int end)
            {
                int pivot = array[end];
                int i = start - 1;

                for (int j = start; j <= end - 1; j++)
                {
                    if (array[j] < pivot)
                    {
                        i++;
                        Swap(array, i, j);
                    }

                }
                i++;
                Swap(array, i, end);
                return i;
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }    
}