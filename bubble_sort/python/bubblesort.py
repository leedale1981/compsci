def bubbleSort(aList):
    for passNum in range(len(aList) - 1, 0, -1):
        
        for i in range(passNum):
            
            if aList[i] > aList[i + 1]:               
                temp = aList[i]
                aList[i] = aList[i + 1]
                aList[i + 1] = temp

    return aList

aList = [8,1,5,2,7,4,9]

print("Unsorted: " + str(aList))

sortedList = bubbleSort(aList)

print("Sorted:" + str(sortedList))
