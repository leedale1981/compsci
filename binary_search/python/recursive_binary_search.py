def binary_search(a_list, first, last, target): 
    middle = (first + last) // 2 
    if a_list[middle] == target: 
        return middle 
    else: 
        if (first <= last):
            if target < a_list[middle]: 
                return binary_search(a_list, first, middle - 1, target)
            else: 
                return binary_search(a_list, middle + 1, last, target)
        else:
            return first


pos = binary_search([2, 5, 8, 11, 17], 0, 4, 9)
print(str(pos))