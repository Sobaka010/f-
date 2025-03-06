open System

let rec schitivanie x =
    match string(Console.ReadLine()) with
    | "" -> List.rev x
    | y -> schitivanie (y :: x) 



printfn "Введите строку через Enter, для завершения введите пустой элемент: "
let list1 = schitivanie []
printfn "Введённый список: %A" list1

let list2 = List.map String.length list1

printfn "Список, содержащий длины введённых строк: %A" list2

(*
open System

let rec schitivanie1 x =
    match string(Console.ReadLine()) with
    | "" -> List.rev x
    | y -> schitivanie1 (y :: x) 

let schitivanie2 =
    let x = new Random()
    let n = x.Next(0, 20)
    [for i in 0 .. n do yield x.Next(-10000, 10000)]


printfn "Выберите способ заполнения списка:"
printfn "1 - Вручную"
printfn "2 - Случайными элементами"

match Console.ReadLine() with
| "1" ->
    printfn "Введите строку через Enter, для завершения введите пустой элемент: "
    let list1 = schitivanie1 []
    printfn "Введённый список: %A" list1

    let list2 = List.map String.length list1
    printfn "Список, содержащий длины введённых строк: %A" list2
| "2" ->
    let list1 = schitivanie2
    printfn "Случайный список: %A" list1

    //let list2 = List.map int.Length list1
    //printfn "Список, содержащий длины случайных элементов: %A" list2
| _ -> 
    printfn "Некорректный ввод, попробуйте снова."
 *)