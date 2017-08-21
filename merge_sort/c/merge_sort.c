#include <stdlib.h>
#include <string.h>

int * merge_sort (int * array, unsigned size);
int * merge(int * left, unsigned leftSize, int * right, unsigned rightSize);

int * merge(int * left, int * right) {
    int n = (sizeof(left)/sizeof(left[0])) + (sizeof(right)/sizeof(right[0]));
    int merged[n];

    
}

int * merge_sort (int * array) {

    int n = sizeof(array)/sizeof(array[0]);

    if (n == 1) {
        return array;
    }

    int halfn = n / 2;
    
    int left[halfn];
    int right[n - halfn];

    for (int i = 0; i < halfn, i++) {
        left[i] = array[i];
    }

    for (int i = 0; i < halfn, i++) {
        right[i] = array[i + halfn];
    }

    left = merge_sort(left);
    right = merge_sort(right);

    return merge(left, right);
}

int main (void) {
    
      // Setup initial unsorted array.
      int array_size = 13;
      int unsorted[] = {9, 5, 3, 8, 2, 1, 4, 7, 6, 13, 10, 12, 11};
    
      // Print out unsorted array.
      for (int index = 0; index < array_size; index++) {
          printf("%d ", unsorted[index]);
      }
    
      printf("\n");
    
      // Create new array pointer.
      int * sorted_array;
    
      // Sort array
      sorted_array = merge_sort(unsorted); 
    
      // Print out sorted array.
      for (int index = 0; index < array_size; index++) {
          printf("%d ", sorted_array[index]);
      }
    
      printf("\n"); 
    
      return 0;
    }