open System

let merge (left:int[]) (right:int[]) =
    let merged = Array.empty<int>
    let i = 0
    let j = 0

    while (i < (Array.length left) && j < (Array.length right)) do
        if (left.[i] < right.[j]) then
            merged = Array.append merged [|left.[i]|]
            i = i + 1
        else
            merged = Array.append merged [|right.[j]|]
            j = j + 1
        
    while (i < (Array.length left)) do
        merged = Array.append merged [|left.[i]|]
        i = i + 1

    while (j < (Array.length right)) do
        merged = Array.append merged [|right.[j]|]
        j = j + 1

    merged
        
let mergeSort (numbers:int[]) = 
    if ((Array.length numbers) > 1) then
        let mid = (Array.length numbers) / 2
        let left = numbers.[0 .. mid]
        let right = numbers.[mid .. (Array.length numbers)]

        mergeSort(left)
        mergeSort(right)

    merge(left, right)


[<EntryPoint>]
let main argv =
    let unsortedList = [|2,4,1,9,7,8,5|]
    let sortedList = mergeSort(unsortedList)

    0 // return an integer exit code
