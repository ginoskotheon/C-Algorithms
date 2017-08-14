using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {4,5,3,1,6,2};

            InsertionSort(nums);     
        }

        public static void InsertionSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = i; j > 0 && nums[j-1] > nums[j]; j--)
                {
                   Swap(nums, j, j-1);
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
