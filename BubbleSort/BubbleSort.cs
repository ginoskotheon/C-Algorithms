using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {4,5,3,1,6,2};
            BubbleSort(nums);
            
        }

        private static void BubbleSort(int[] nums)
        {
            int n = nums.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < n - 1; i++ )
                {
                    if (nums[i] > nums[i+1])
                    {
                        int temp = nums[i+1];
                        nums[i+1] = nums[i];
                        nums[i]  = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);

            PrintArray(nums);
        }

        private static void PrintArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                Console.Write("{0} ", nums[i] ); 
        }
    }
}
