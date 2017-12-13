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