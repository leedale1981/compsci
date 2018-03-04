def binary_search(a_list, first, last, target): 
    """Return the position where target is or should be inserted.
    
    Assume 0 <= first < len(a_list) and last < len(a_list).
    Assume a_list[first] <= a_list[first+1] <= ... <= a_list[last] 
    if first <= last.
    """
    while first <= last: 
        middle = (first + last) // 2 
        if a_list[middle] == target: 
            return middle 
        if target < a_list[middle]: 
            last = middle - 1 
        else: 
            first = middle + 1 
    return first

def insertion_sort(a_list):
    """Sort a_list in ascending order. 
    
    
    Use insertion sort with binary search.
    """
   
    for index in range(1, len(a_list)):
        value = a_list[index]
        position = binary_search(a_list, 0, index, value)

        for subIndex in range(index, position, -1):
            temp = a_list[subIndex]
            a_list[subIndex] = a_list[subIndex - 1]
            a_list[subIndex - 1] = temp




import time

# the length of the input list
size = 32000    # CHANGE THIS

# Create a list of integers in descending order (worst-case scenario)
test_list = []
for index in range(size):
    test_list.append(size - index)
# Time the execution of the sorting algorithm
start = time.time()
insertion_sort(test_list)
elapsed = (time.time() - start) * 1000
print(size, 'integers sorted in', int(elapsed), 'milliseconds')