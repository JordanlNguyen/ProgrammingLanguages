import Foundation

func Task3(n: Int) -> Int{
    if (n == 1 || n == 0){
        return 1
    }
    else{
        return n * (n - 1)
    }
}

let res = Task3(n : 1)
print(res)