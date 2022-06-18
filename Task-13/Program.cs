// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

using System;
using static System.Console;

Clear();

Write("Введите число: ");
string? number = ReadLine();

if (number?.Length < 3) WriteLine("Третьей цифры нет");
else WriteLine($"Третья цифра числа {number} является {number?[2]}");