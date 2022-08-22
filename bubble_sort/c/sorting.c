#include <stdio.h>
#include "bubble_sort.h"

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