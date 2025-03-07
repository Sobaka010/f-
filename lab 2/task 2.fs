
let sum list y = // y - цифра
    List.fold (fun acc x2 -> 
        if proverka x2 y then // х2 - число, в котором есть y
            acc + x2  
        else
            acc) 0 list  


printfn "Выберите способ заполнения списка:"
printfn "1 - Случайными числами"
printfn "2 - Вручную"
match Console.ReadLine() with
| "1" ->
    printf "Введите кол-во элементов в случайном списке: "
    let n = int(Console.ReadLine())
    printf "Введите МИНИМАЛЬНОЕ значение элемента в списе:  "
    let min = int(Console.ReadLine())
    printf "Введите МАКСИМАЛЬНОЕ значение элемента в списе: "
    let max = int(Console.ReadLine())
    let list = (generator_r n min max)
    printf "Случайный список: %A" list
    printf "\nВведите цифру: "
    let y = int(Console.ReadLine())

    let s = (sum list y)
    printf "Сумма всех элементов, содержащих эту цифру: %A\n\n" s

| "2" ->
    printf "Введите кол-во элементов в случайном списке: "
    let n = int(Console.ReadLine())
    let list = (generator_k n)
    printf "Ваш список: %A" list
    printf "\nВведите цифру: "
    let y = int(Console.ReadLine())

    let s = (sum list y)
    printf "Сумма всех элементов, содержащих эту цифру: %A\n\n" s

| _ -> printfn "Некорректный ввод, попробуйте снова."
