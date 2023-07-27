﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString(); 
//     return start + ", " + PrintNumbers(start - 1, end);
// }
// Console.WriteLine($"Числа от {n} до 1: {PrintNumbers(n, 1)}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int copyN = n + 1;
int SumNumbers(int m, int copyN)
{
    if (m == copyN) return 0;
    else
    {
        return m + SumNumbers(m + 1, copyN);
    }
}
Console.WriteLine($"Cумма чисел в промежутке от {m} до {n}: {SumNumbers(m, copyN)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.