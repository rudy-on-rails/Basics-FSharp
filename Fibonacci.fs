let rec fibonacciRecur = fun(list : List<int>, first : int, second : int, numberstocalc : int) -> 
    if list.Length = numberstocalc then
        list
    else
        fibonacci(first :: list, second, first + second, numberstocalc)

let fibonacci = fun(numberstocalc) -> fibonacciRecur([], 0, 1, numberstocalc)

let rest = fibonacci(15)