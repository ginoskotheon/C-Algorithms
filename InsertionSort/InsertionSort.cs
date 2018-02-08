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
            int newValue;
            for (int i = 1; i < nums.Length; i++)
            {
                newValue = nums[i];
                int j = i;
                while(j > 0 && nums[j-1] > newValue)
                {
                    nums[j] = nums[j-1];
                    j--;
                }
                nums[j] = newValue;
            }

            PrintArray(nums);
        }

        private static void PrintArray(int[] nums)
        {
            foreach (int num in nums){
                Console.Write(num + " ");
            } 
        }
    }
}
