class BubbleSort {
    sort(input) {
        // Make as many passes through the input as there are items.
        for (let passIndex = 0; passIndex < input.length; passIndex++) {
            for (let index = 0; index < input.length; index++) {
                let firstItem = input[index];
                let secondItem = input[index + 1]
    
                if (firstItem > secondItem) {
                    input[index] = secondItem;
                    input[index + 1] = firstItem;
                }
            }
        }

        return input;
    }
}

bubbleSort = new BubbleSort();
let sorted = bubbleSort.sort([9,6,4,5,8,2]);
console.log(sorted);