﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.Write("Write number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) 
Console.Write($"Number " + num + " is even");
else
Console.Write($"Number " + num + " is NOT even");