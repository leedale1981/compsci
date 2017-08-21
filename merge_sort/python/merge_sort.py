def merge(left, right):
    merged = [];

    while len(left) > 0 and len(right) > 0:
        if (left[0] > right[0]):
            merged.append(right[0]);
            del right[0];
        else:
            merged.append(left[0]);
            del left[0];

    while len(left) > 0:
        merged.append(left[0]);
        del left[0];

    while len(right) > 0:
        merged.append(right[0]);
        del right[0];

    return merged;

def merge_sort(array):
    n = len(array); 

    if n == 1:
        return array;
    
    halfn = n / 2;
    
    left = [];
    right = [];

    for i in range(0, halfn):
        left.append(array[i]);

    for i in range(halfn, n):
        right.append(array[i]);

    left = merge_sort(left);
    right = merge_sort(right);

    return merge(left, right);



unsorted_array = [9, 5, 3, 8, 2, 1, 4, 7, 6, 13, 10, 12, 11];

for i in range(len(unsorted_array)):
    print unsorted_array[i];

print "\n";

sorted_array = merge_sort(unsorted_array);

for i in range(len(sorted_array)):
    print sorted_array[i];