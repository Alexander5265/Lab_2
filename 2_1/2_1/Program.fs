open System

// Функция для вычисления произведения цифр числа
let product (n: int) =
    let rec prod x =
        if x = 0 then 1
        else (x % 10) * prod (x / 10)

    let a = abs n
    if a = 0 then 0
    else prod a

// Функция, которая получает список произведений цифр
let getProducts (numbers: int list) =
    numbers |> List.map product

printfn "Исходный список через пробел: "
let input1 = Console.ReadLine()
let list1 = input1.Split(' ') |> Array.toList |> List.map int

let result = getProducts list1

printfn "%A" result
