def merge(array, p, q, r):
    n1 = q - p + 1;
    n2 = r - q;

    left = [];
    right = [];

    for i in range(0, n1):
        left.append(array[p + i - 1]);
    
    for j in range(0, n2):
        right.append(array[q + j]);

    left.append(999999999999);
    right.append(99999999999);
    i = 0;
    j = 0;

    for k in range(p - 1, r):
        if left[i] <= right[j]:
            array[k] = left[i];
            i = i + 1;
        else:
            array[k] = right[j];
            j = j + 1;

    return array;

def merge_sort(array, p, r):
    if p < r:
        q = (p + r) / 2;
        array = merge_sort(array, p, q);
        array = merge_sort(array, q + 1, r);
        return merge(array, p, q, r);
    else:
        return merge(array, p, 1, r);

unsorted_array = [9, 5, 3, 8, 2, 1, 4, 7, 6, 13, 10, 12, 11];

for i in range(len(unsorted_array)):
    print unsorted_array[i];

print "\n";

sorted_array = merge_sort(unsorted_array, 0, len(unsorted_array));

for i in range(len(sorted_array)):
    print sorted_array[i];