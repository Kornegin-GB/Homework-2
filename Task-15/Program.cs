// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

using System;
using static System.Console;

Clear();

Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(ReadLine());

switch (number)
{
   case 1:
   case 2:
   case 3:
   case 4:
   case 5:
      {
         WriteLine("Рабочий день");
         break;
      }
   case 6:
   case 7:
      {
         WriteLine("Выходной день");
         break;
      }
   default:
      {
         WriteLine("Такого дня недели нет");
         break;
      }
}