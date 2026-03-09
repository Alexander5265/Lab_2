open System

// функция перевода двоичного числа в десятичное
let binaryToDecimal (binary: string) =
    Convert.ToInt32(binary, 2)

// функция для вычисления суммы с помощью List.fold
let sumBinaryNumbers (numbers: string list) =
    List.fold (fun sum element ->
        sum + binaryToDecimal element
    ) 0 numbers


[<EntryPoint>]
let main argv =

    printfn "Исходный двоичный список через пробел: "
    let input1 = Console.ReadLine()
    let list1 = input1.Split(' ') |> Array.toList
        
    let result = sumBinaryNumbers list1

    printfn "Сумма = %d" result

    0