﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write($"Введите трехзначное число: ");
string number = Console.ReadLine()!;
Console.Write($"Вторая цифра = {number[1]}\n");