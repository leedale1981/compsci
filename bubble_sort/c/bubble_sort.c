#include <stdio.h>

int *sort(int *input, int size)
{
    // Make as many passes through the input as there are items.
    for (int passIndex = 0; passIndex < size; passIndex++)
    {
        // Now iterate the input and do the swapping.
        for (int index = 0; index < size; index++)
        {
            int firstItem = input[index];
            int secondItem = input[index + 1];

            if (firstItem > secondItem)
            {
                input[index] = secondItem;
                input[index + 1] = firstItem;
            }
        }
    }

    return input;
}

int main()
{
    int input[] = {9, 6, 4, 5, 8, 2};
    int arraySize = (int)(sizeof(input) / sizeof(input[0]));
    int *output = sort(input, arraySize);

    for (int index = 0; index < arraySize; index++)
    {
        printf("%d ", output[index]);
    }
}