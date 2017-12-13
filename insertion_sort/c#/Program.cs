using System;
using System.Collections.Generic;

namespace lee.compsci.algos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> unsortedList = new List<int>() {2,4,1,9,7,8,5};
            List<int> sortedList = InsertionSort(unsortedList);
        }

        static List<int> InsertionSort(List<int> numbers)
        {
            for (int index = 0; index < numbers.Count; index++)
            {
                int currentValue = numbers[index];
                int position = index;

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
