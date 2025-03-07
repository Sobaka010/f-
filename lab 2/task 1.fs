open System

let rec schitivanie n =
    if n <= 0 then
        []
    else
        let y = string(Console.ReadLine())
        y :: schitivanie (n-1) 

let isNumber (input: string) =
    match Int32.TryParse(input) with
    | (true, _) -> true
    | (false, _) -> false

printf "Введите кол-во строк в списке: "
let n = Console.ReadLine()
if (isNumber n) && int(n) >= 0 then
    printfn "Введите строку через Enter, для завершения введите пустой элемент: "
    let list1 = (schitivanie (int(n)))
    printfn "Введённый список: %A" list1
    let list2 = List.map String.length list1
    printfn "Список, содержащий длины введённых строк: %A" list2
else 
    printf "Ошибка Ввода\n\n"
