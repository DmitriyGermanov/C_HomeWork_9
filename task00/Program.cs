// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumber(string text) //Функция запрашивает от пользователя целое число
{
    Console.Write($"{text} ");
    return int.Parse(Console.ReadLine()!);
}



string SerialOfNubmers(int n) // Функция выводит последовательность Четных чисел от N до 2
{
    if (n > 0)
    {
        if (n % 2 == 0)
        {
            if (n == 2)
                return Convert.ToString(n) + SerialOfNubmers(n - 1);
            else
                return Convert.ToString(n) + ", " + SerialOfNubmers(n - 1);
        }
        else return
        SerialOfNubmers(n - 1);
    }
    else
        return "";
}

int n = GetNumber("Введите длину промежутка N: ");
Console.WriteLine(SerialOfNubmers(n));