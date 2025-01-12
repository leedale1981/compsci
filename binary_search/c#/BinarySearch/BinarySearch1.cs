namespace BinarySearch;

public class BinarySearch1
{
    public static int BinarySearch(int[] list, int first, int last, int target)
    {
        int middle = (first + last) / 2;

        if (middle == target)
        {
            return middle;
        }

        if (target < middle)
        {
            return BinarySearch(list, first, middle - 1, target);
        }

        if (target > middle)
        {
            return BinarySearch(list, middle + 1, last, target);
        }

        return 0;
    }
}