package main

import "fmt"

func binary_search(list []int, first int, last int, target int) int {
	middleIndex := (first + last) / 2
	middle := list[middleIndex]

	if (middle == target) {
		return middle
	}

	return 0
}

func main() {
	list := []int{1,3,6,8,9}
	target := 8
	result := binary_search(list, 0, len(list) -1, target)
	fmt.Printf("result: " + string(result))
}