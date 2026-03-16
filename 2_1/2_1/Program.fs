open System

// Функция для вычисления произведения цифр числа
let product (n: int) =
    let a = abs n
    if a = 0 then 0
    else
        let rec prod x =
            if x = 0 then 1
            else (x % 10) * prod (x / 10)
        prod a

let getProducts (numbers: int list) =
    List.map product numbers

[<EntryPoint>]
let main argv =

    printfn "Исходный список через пробел: "
    let input1 = Console.ReadLine()
    let list1 = input1.Split(' ') |> Array.toList |> List.map int
        
    let result = getProducts list1

    printfn "Результат: %A" result

    0
