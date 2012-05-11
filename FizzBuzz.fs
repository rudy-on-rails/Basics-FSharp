let DivisibleBy = fun number div -> number % div = 0
let DivisibleByThree = fun number -> DivisibleBy number 3
let DivisibleByFive = fun number -> DivisibleBy number 5

let FizzBuzz = fun number -> 
    if DivisibleByThree number && DivisibleByFive number then
        "FizzBuzz" 
    else if DivisibleByThree number then
        "Fizz"
    else if DivisibleByFive number then
        "Buzz"
    else
        number.ToString()

let result = FizzBuzz 124