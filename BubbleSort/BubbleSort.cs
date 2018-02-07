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
                        Swap(ref nums[i], ref nums[i+1]);
                        swapped = true;
                    }
                }
            } while (swapped == true);

            PrintArray(nums);
        }

         private static void Swap(ref int n1, ref int n2)
        {
            int temp = n2;
            n2 = n1;
            n1 = temp; 
        }

        private static void PrintArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                Console.Write("{0} ", nums[i] ); 
        }
    }
}
