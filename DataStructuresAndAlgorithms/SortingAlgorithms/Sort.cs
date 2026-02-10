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

    // LEET CODE 1480
    public class RunningSumOf1DArray
    {
        public static int[] RunningSum(int[] nums)
        {
            int[] output = new int[nums.Length];

            int number = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                number = number + nums[i];
                output[i] = number;
            }
            Console.WriteLine(output);
            return output; 
        }
    }
}