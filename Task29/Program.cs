using System;
Console.Clear();

/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int[] mass = new int [8];
string t = Console.ReadLine();;
Console.WriteLine($"{String.Join(", ", t.ToArray())} -> ");

