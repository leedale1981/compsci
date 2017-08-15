#include <stdlib.h>
#include <string.h>

int * insertion_sort (int * array, unsigned size);

int * insertion_sort (int * array, unsigned size) {
 
  for (int j = 1; j < size; j++) {

    int i = j - 1;
    int key = array[j];

    while (i > -1 && array[i] > key) {
      array[i + 1] = array[i];
      i = i - 1; 
    }
    array[i + 1] = key;

  }

  return array;
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
  sorted_array = insertion_sort(unsorted, array_size); 

  // Print out sorted array.
  for (int index = 0; index < array_size; index++) {
      printf("%d ", sorted_array[index]);
  }

  printf("\n"); 

  return 0;
}