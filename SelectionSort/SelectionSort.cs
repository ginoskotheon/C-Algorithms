using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {4,5,3,1,6,2};

            SelectionSort(nums);
        }

        public static void SelectionSort(int[] nums)
        {
            int i, j;
            int n = nums.Length;

            for (i = 0; i < n - 1; i++)
            {
                int iMin = i;
                for ( j = i; j < n; j++)
                {
                    if (nums[j] < nums[iMin])
                    {
                        iMin = j;
                    }
                }
                if (iMin != i)
                {
                    Swap(nums, i, iMin);
                }
            }
            PrintArray(nums); 
        }

        public static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        private static void PrintArray(int[] nums)
        {
            foreach (int num in nums){
                Console.Write(num + " ");
            } 
        }
    }
}
