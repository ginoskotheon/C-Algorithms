using System;
using System.Collections.Generic;
using System.Linq;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {10, 64, 7, 52, 32, 18, 2, 48};
            HeapSort hs = new HeapSort();
            hs.PerformHeapSort(nums);
        }
    }
}
