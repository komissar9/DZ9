// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString(); 
    return start + ", " + PrintNumbers(start - 1, end);
}
Console.WriteLine($"Числа от {n} до 1: {PrintNumbers(n, 1)}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
Console.Write("Введите число M: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());
int copyN = userN + 1;
if (userM < copyN)
{

    int SumNumbers(int M, int N)
    {

        if (M == N) return 0;
        else
        {
            return M + SumNumbers(M + 1, N);
        }
    }
    Console.WriteLine($"Cумма чисел в промежутке от {userM} до {userN}: {SumNumbers(userM, copyN)}");

}
else
{
    Console.WriteLine("Число M должно быть меньше числа N");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > 0 && n > 0)
{
    int akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return akkerman(m - 1, 1);
        else return akkerman(m - 1, akkerman(m, n - 1));
    }
    Console.Write($"Функция Аккермана равно {akkerman(m, n)}");
}
else 
{
    Console.WriteLine("Есть отрицательные числа");
}