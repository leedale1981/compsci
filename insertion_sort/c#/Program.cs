using System;
using System.Collections.Generic;

namespace lee.compsci.algos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedList = new int[] {2,4,1,9,7,8,5};
            int[] sortedList = InsertionSort(unsortedList);
        }

        // If inversion count is O(n) then complexity is O(n)
        // Worse case inversion could is when input is in reverse order giving n*(n-1)/2 inversions.
        // Worse case therefore is O(n^2)
        static int[] InsertionSort(int[] numbers)
        {
            // Iterates n times
            for (int index = 0; index < numbers.Length; index++)
            {
                int currentValue = numbers[index];
                int position = index;

                // Iterates for number of inversions.
                // If sorted in reverse then inversions could be n*(n-1)/2.
                while (position > 0 && numbers[position - 1] > currentValue)
                {
                    numbers[position] = numbers[position - 1];
                    position = position - 1;
                }

                numbers[position] = currentValue;
            }

            return numbers;
        }
    }
}
