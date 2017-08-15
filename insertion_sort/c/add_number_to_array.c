#include <stdlib.h>
#include <string.h>

int * insertion_sort (int * array, unsigned size);

int * insertion_sort (int * array, unsigned size) {
  int * copy = realloc(array, sizeof(int) * size);
  
  copy[size -1] = 6;  

  return copy;
}

int main (void) {
  int * a = malloc(sizeof(int) * 5);
  a[0] = 1;
  a[1] = 2;
  a[2] = 3;
  a[3] = 4;
  a[4] = 5;

  for (int index = 0; index < 5; index++) {
      printf("%d ", a[index]);
  }

  printf("\n");

  int * b;

  b = insertion_sort(a, 6); 

  for (int index = 0; index < 6; index++) {
      printf("%d ", b[index]);
  }

  printf("\n");
  
  free(b);

  return 0;
}