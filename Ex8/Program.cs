﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine ("Введите число  ");
int N = Convert.ToInt32 (Console.ReadLine());
int count = 0;

while (count <= N)
{
    int Num = count % 2;
    if (Num > 0)
    {
        count = count + 1;  
    }
    else
    {
        Console.WriteLine (count);
        count = count + 1;  
    }
    
}

Console.WriteLine ("End");