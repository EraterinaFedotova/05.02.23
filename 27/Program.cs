﻿// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Clear();
Console.Write ("Введите число: ");
int number = int.Parse (Console.ReadLine ());
Console.Write($"Сумма цифр числа {number} равна {getSum(number)}");

 int getSum(int n)
    {
        int sum = 0;
 
        while (n != 0) {
            sum = sum + n % 10;
            n = n / 10;
        }
 
        return sum;
    }
