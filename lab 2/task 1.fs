open System

let rec schitivanie n =
    if n <= 0 then
        []
    else
        let y = string(Console.ReadLine())
        y :: schitivanie (n-1) 


printf "Введите кол-во строк в списке: "
let n = int (Console.ReadLine())
printfn "Введите строку через Enter, для завершения введите пустой элемент: "
let list1 = (schitivanie n)
printfn "Введённый список: %A" list1

let list2 = List.map String.length list1

printfn "Список, содержащий длины введённых строк: %A" list2
