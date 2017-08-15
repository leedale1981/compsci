def insertion_sort(array):

    for j in range(2, len(array)):
        i = j - 1;
        key = array[j];

        while (i > -1 and array[i] > key):
            array[i + 1] = array[i];
            i = i -1;

        array[i + 1] = key;

    return array;

unsorted_array = [9, 5, 3, 8, 2, 1, 4, 7, 6, 13, 10, 12, 11];

for i in range(len(unsorted_array)):
    print unsorted_array[i];

print "\n";

sorted_array = insertion_sort(unsorted_array);

for i in range(len(sorted_array)):
    print sorted_array[i];


