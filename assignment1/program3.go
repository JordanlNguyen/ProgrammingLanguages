package main

import "fmt"

func Task3(n int) int{
	if(n == 1 || n == 0){
		return 1
	}
	return n * (n - 1)
}

func main(){
	var res int = Task3(100)
	fmt.Print(res)
}