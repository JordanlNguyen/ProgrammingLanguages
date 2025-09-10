import Foundation

func Task2(n : Int){
    var a : [Int] = []
    var evenCount = 0
    for _ in 0..<n{
        a.append(Int.random(in: 1...1000000))
    }
    for i in 0..<n{
        if(a[i]%2 == 0){
            evenCount += 1
        }
    }
    print("Even Count: \(evenCount)")
}

Task2(n: 1000)