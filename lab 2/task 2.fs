open System

let rec proverka x y = // х - число, y - цифра
    let x = abs x
    if x = 0 then
        false
    else
        if x % 10 = y then
            true  
        else
            proverka (x / 10) y

let rec generator_r n min max =
    if n <= 0 then
        []  
    else
        let random = new Random()
        let x = random.Next(min, max) 
        x :: (generator_r (n - 1) min max)

let rec generator_k n =
    if n <= 0 then
        []
    else
        let x = int(Console.ReadLine())
        x :: (generator_k (n-1))

let sum list y = // y - цифра
    List.fold (fun acc x2 -> 
        if proverka x2 y then // х2 - число, в котором есть y
            acc + x2  
        else
            acc) 0 list  

let isNumber (input: string) =
    match Int32.TryParse(input) with
    | (true, _) -> true
    | (false, _) -> false

printfn "Выберите способ заполнения списка:"
printfn "1 - Случайными числами"
printfn "2 - Вручную"
match Console.ReadLine() with
| "1" ->
    printf "Введите кол-во элементов в случайном списке: "
    let n = String(Console.ReadLine())
    printf "Введите МИНИМАЛЬНОЕ значение элемента в списе:  "
    let min = String(Console.ReadLine())
    printf "Введите МАКСИМАЛЬНОЕ значение элемента в списе: "
    let max = String(Console.ReadLine())
    if (isNumber n) && (int(n) >= 0) && (isNumber min) && (isNumber max) then
        let list = (generator_r (int(n)) (int(min)) (int(max)))
        printf "Случайный список: %A" list
        printf "\nВведите цифру: "
        let y = String(Console.ReadLine())
        if (isNumber y) && (int(y) >= 0) && (int(y) <10) then
            let s = (sum list (int(y)))
            printf "Сумма всех элементов, содержащих эту цифру: %A\n\n" s
        else
            printf "Ошибка Ввода\n\n"
     else 
        printf "Ошибка Ввода\n\n"

| "2" ->
    printf "Введите кол-во элементов в случайном списке: "
    let n = String(Console.ReadLine())
    if (isNumber n) && (int(n) >= 0) then
        let list = (generator_k (int(n)))
        printf "Ваш список: %A" list
        printf "\nВведите цифру: "
        let y = int(Console.ReadLine())
        let s = (sum list y)
        printf "Сумма всех элементов, содержащих эту цифру: %A\n\n" s
    else
        printf "Ошибка Ввода\n\n"

| _ -> printfn "Некорректный ввод, попробуйте снова."
