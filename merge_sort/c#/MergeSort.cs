namespace Lee.CompSci.DataStructures;

public static class MergeSort
{
    public static int[] Sort(int[] array)
    {
        if (array.Length == 1)
        {
            return array;
        }

        int halfLength = array.Length / 2;

        int[] leftArray = new int[halfLength];
        int[] rightArray = new int[halfLength];

        for (int index = 0; index < halfLength; index++)
        {
            leftArray[index] = array[index];
        }

        for (int index = halfLength; index < array.Length; index++)
        {
            rightArray[index] = array[index];
        }

        leftArray = Sort(leftArray);
        rightArray = Sort(rightArray);

        return Merge(leftArray, rightArray);
    }

    private static int[] Merge(int[] leftArray, int[] rightArray)
    {
        int mergedLength = leftArray.Length + rightArray.Length;
        int[] merged = new int[mergedLength];

        while (leftArray.Length > 0 && rightArray.Length > 0)
        {

        }
    }
}