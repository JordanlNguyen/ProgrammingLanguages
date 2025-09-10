package main

import "fmt"

func main(){
	var name string
	fmt.Print("Enter name: ")
	fmt.Scanln(&name)
	strArray := []rune(name)
	l := 0
	r := len(strArray) - 1
	for l < r{
		var tmp = strArray[l]
		strArray[l] = strArray[r]
		strArray[r] = tmp
		l += 1
		r -= 1
	}
	var reversedString string = string(strArray)
	fmt.Print("Reversed name: ", reversedString)

}