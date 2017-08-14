using System;
using System.Collections.Generic;
using System.Linq;

namespace HeapSort
{
    class HeapSort
    {
        private int heapSize;

        private void BuildHeap(int[] nums)
        {
            heapSize = nums.Length -1;
            for(int i = heapSize/2; i >=0; i --)
            {
                Heapify(nums, i);
            }
        }

        private void Swap(int[] nums, int x, int y)
        {
            int temp = nums[x];
            nums[x] = nums[y];
            nums[y] = temp;
        }

        private void Heapify(int[] nums, int index)
        {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && nums[left] > nums[index])
            {
                largest = left;
            }

            if (right <= heapSize && nums[right] > nums[largest])
            {
                largest = right;
            }

            if(largest != index)
            {
                Swap(nums, index, largest);
                Heapify(nums, largest);
            }
        }

        public void PerformHeapSort(int[] nums)
        {
            BuildHeap(nums);
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Swap(nums, 0, i);
                heapSize--;
                Heapify(nums, 0);
            }
            DisplayArray(nums);
        }
        private void DisplayArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
        }
    }
}