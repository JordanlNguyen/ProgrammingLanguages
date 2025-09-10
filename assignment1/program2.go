package main

import "fmt"
import "math/rand"

func main(){
	var n int = 1000
	var evenCount = 0
	var a [1000]int
	for i := 0; i < n; i++{
		a[i] = rand.Intn(999)+1
	}
	for i := 0; i < n; i++{
		if (a[i]%2 == 0){
			evenCount++
		}
	}
	fmt.Print("Even Count: ", evenCount)
}