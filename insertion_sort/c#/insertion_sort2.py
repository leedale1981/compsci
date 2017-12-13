def insertionSort(aList):
    
    for i in range(1, len(aList)):
        
        currentValue = aList[i]
        position = i

        while position > 0 and aList[position - 1] > currentValue:
            aList[position] = aList[position - 1]
            position = position - 1
        aList[position] = currentValue

    return aList

aList = [8,1,5,2,7,4,9]

print("Unsorted: " + str(aList))

sortedList = insertionSort(aList)

print("Sorted:" + str(sortedList))