using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class Program
    {

        static void Main(string[] args)
        {    
            TestMergeSort();
        }

        private static void TestMergeSort()
        {
            int[] nums = {4,5,3,8,9,1, 23, 2, 6, 75};
            MergeSorter.DoMergeSort(nums);
            foreach (int number in nums)
            {
                Console.Write(number + " ");
            }
        }

    }
}
