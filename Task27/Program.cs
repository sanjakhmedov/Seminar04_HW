﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter the number: ");
int n = Convert.ToInt32(Console.ReadLine());


int SumDigits(int num)
{
    int res = num % 10;
    if (num > 0)
    {
        for (int i = 0; num / 10 > 0; i++)
        {
            num = num / 10;
            res = res + num % 10;
        }
        return res;
    }
    else
    {
        Console.WriteLine("Please enter the positive number!");
        return 0;
    }
}

int sumDigits = SumDigits(n);

Console.WriteLine($"Sum of the digits of {n} equals {sumDigits}.");