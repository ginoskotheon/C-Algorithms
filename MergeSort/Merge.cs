using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{    class MergeSorter
    {
        public static void DoMergeSort(int[] numbers)
        {
            var sortedNumbers = MergeSort(numbers);
            for (int i = 0; i < sortedNumbers.Length; i++) numbers[i] = sortedNumbers[i];
        }
        
        private static int[] MergeSort(int[] numbers)
        {
            //base case
            if (numbers.Length <= 1) return numbers;

            var left = new List<int>();
            var right = new List<int>();

            Divide(numbers, left, right);

            left = MergeSortList(left);
            right = MergeSortList(right);

            return Merge(left, right);
        }

        private static List<int> MergeSortList(List<int> list)
        {
            return MergeSort(list.ToArray()).ToList();
        }

        private static void Divide(int[] numbers, List<int> left, List<int> right)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOdd(i)) left.Add(numbers[i]);
                else right.Add(numbers[i]);
            }
        }

        private static bool IsOdd(int i)
        {
            return i % 2 > 0;
        }

        private static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while(NotEmpty(left) && NotEmpty(right))
            {
                if(left.First() <= right.First())  MoveValueFromSourceToResult(left,result);
                else MoveValueFromSourceToResult(right, result);
            }

            while(NotEmpty(left)) MoveValueFromSourceToResult(left, result);
            while(NotEmpty(right)) MoveValueFromSourceToResult(right, result);

            return result.ToArray();  
        }
        private static bool NotEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void MoveValueFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
