// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string text) //Функция запрашивает от пользователя целое число
{
    Console.Write($"{text} ");
    return int.Parse(Console.ReadLine()!);
}

int Ackermann(int m, int n)  //Функция аккермана (себе, при 1/1 сработает в последнем return 2 раза)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    if (m > 0 && n > 0)  // 2   2        return 
        return Ackermann(m - 1, Ackermann(m, n - 1));

        else
        return 0;
}
int m = GetNumber("Введите целое неотрицательное число m:");
int n = GetNumber("Введите целое неотрицательное число n:");
int result = Ackermann(m,n);
Console.WriteLine($"Для m = {m} и n = {n} результат = {result}");

