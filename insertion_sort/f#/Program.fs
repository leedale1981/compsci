// Learn more about F# at http://fsharp.org

open System

let insertionSort numbers =
    for index = 0 to numbers.Length - 1 do
        let currentValue = numbers[index]
        let position = index

        while (position > 0 && numbers[position - 1] > currentValue) do
            numbers[position] = numbers[position - 1]
            position = position - 1

        numbers[position] = currentValue

    return numbers

[<EntryPoint>]
let main argv =
    let unsortedList = [2,4,1,9,7,8,5]
    let sortedList = insertionSort(unsortedList)

    0 // return an integer exit code


