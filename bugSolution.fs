let xRef = ref 10
let yRef = ref 20

let swap xRef yRef = 
    let temp = !xRef
    xRef := !yRef
    yRef := temp

swap xRef yRef
printfn "%d %d" !xRef !yRef

//Alternative solution using tuples
let swapTuple (x,y) = (y,x)
let xTuple, yTuple = swapTuple (10,20)
printfn "%d %d" xTuple yTuple