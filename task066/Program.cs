﻿// Задача 66: 
// 1.Задайте значения M и N. Напишите программу,которая 
// 2.найдёт сумму натуральных элементов в промежутке от M до N. 
// 3.Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

SumFromMToN(M, N);

void SumFromMToN(int M, int N)
{
    Console.Write(SumMN(M - 1, N));
}

int SumMN(int M, int N)
{
    int res = M;
    if (M == N) return 0;
    else
    {
        M++;
        res = M + SumMN(M, N);
        return res;
    }
}
