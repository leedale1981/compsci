package main

import "fmt"

func fibRecursive(cache map[int]int, n int) int {
	if n == 0 || n == 1 {
		return n
	}

	memoValue := cache[n]

	if memoValue != 0 {
		return memoValue
	} else {
		cache[n] = fibRecursive(cache, n-1) + fibRecursive(cache, n-2)
	}

	return fibRecursive(cache, n-1) + fibRecursive(cache, n-2)
}

func fibRecursiveMemo(n int) int {
	cache := make(map[int]int)

	memoValue := cache[n]

	if memoValue == 0 {
		cache[n] = fibRecursive(cache, n)
	}

	return cache[n]
}

func main() {
	n := 10
	answer := fibRecursiveMemo(n)
	fmt.Printf("Fib for %v is %v", n, answer)
}
