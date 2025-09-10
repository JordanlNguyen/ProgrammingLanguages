import Foundation

func main(){
    Task1()
}

func Task1(){
    print("Enter name: ")
    if let name = readLine(){
        var strArray = Array(name)
        var l = 0
        var r = name.count - 1;
        while(l < r){
            let tmp = strArray[l]
            strArray[l] = strArray[r]
            strArray[r] = tmp
            l += 1
            r -= 1
        }
        let strReversed = String(strArray)
        print("Reversed name is: \(strReversed)")
    }
}

main()