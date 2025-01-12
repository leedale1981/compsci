using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");

            // Create an unsorted list
            int[] list = new int[] {6,8,1,9,2,4,3};

            // First sort the list using an insertion sort so we can apply binary search to it.
            int[] sortedList = InsertionSort(list);

            // Search for number 3
            int searchResult = BinarySearch1.BinarySearch(list, 0, list.Length, 3);

            // Total complexity of insertion sort with binary search is 
            // O(n log n) however worse case can be O(n^2 log n)
            Console.WriteLine(searchResult);
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
