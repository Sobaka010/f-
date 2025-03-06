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

let rec generator n min max =
    if n <= 0 then
        []  
    else
        let random = new Random()
        let number = random.Next(min, max) 
        number :: (generator (n - 1) min max)

let sum list y = // х - число, y - цифра
    List.fold (fun acc x2 -> 
        if proverka x2 y then // х2 - число, в котором есть y
            acc + x2  
        else
            acc) 0 list  

printf "Введите кол-во элементов в случайном списке: "
let n = int(Console.ReadLine())
printf "Введите МИНИМАЛЬНОЕ значение элемента в списе:  "
let min = int(Console.ReadLine())
printf "Введите МАКСИМАЛЬНОЕ значение элемента в списе: "
let max = int(Console.ReadLine())
let list = (generator n min max)
printf "Случайный список: %A" list
printf "\nВведите цифру: "
let y = int(Console.ReadLine())

let s = (sum list y)
printf "Сумма всех элементов, содержащих эту цифру: %A\n\n" s
