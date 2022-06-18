// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;
using static System.Console;

Clear();

Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(ReadLine());

WriteLine($"Вторая цифра числа {number} является {number % 100 / 10}");