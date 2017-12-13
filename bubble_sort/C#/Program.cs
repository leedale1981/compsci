using System;
using System.Linq;

namespace compsci.algos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aList = {8, 1, 5, 2, 7, 4, 9};
            Console.WriteLine("Unsorted: " + string.Join(", ", aList));

            int[] sortedList = BubbleSort(aList);
            Console.WriteLine("Sorted: " + string.Join(", ", sortedList));
        }

        static int[] BubbleSort(int[] aList)
        {
            for (int passNum = aList.Length - 1; passNum > 0; passNum--)
            {
                for (int i = 0; i < passNum; i++)
                {
                    if (aList[i] > aList[i + 1])
                    {
                        int temp = aList[i];
                        aList[i] = aList[i + 1];
                        aList[i + 1] = temp;
                    }
                }
            }

            return aList;
        }
    }
}
