// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string text) //Функция запрашивает от пользователя целое число
{
    Console.Write($"{text} ");
    return int.Parse(Console.ReadLine()!);
}

int SummOfLine(int m, int n) //Функция находит сумму элементов в промежутке от m до n
{
    if (m <= n)
        return m + SummOfLine(m + 1, n);
    else
        return 0;
}

int m = GetNumber("Введите начальное значение промежутка:");
int n = GetNumber("Введите последнее значение промежутка:");
int summ = SummOfLine(m, n);

Console.WriteLine($"Сумма элементов промежутка от {m} до {n} = {summ}");