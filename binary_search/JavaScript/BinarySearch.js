const binarySearch = (list, first, last, target) => {
    let middle = (first + last) / 2;
    
    if (target === middle) {
        return middle;
    }
    
    if (target < middle) {
        return binarySearch(list, first, middle -1, target);
    }
    
    if (target > middle) {
        return binarySearch(list, middle + 1, last, target);
    }
    
    return 0;
}