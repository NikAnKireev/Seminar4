using System;
Console.Clear();

/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.Write("Введите число A: ");
int A =int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B =int.Parse(Console.ReadLine());

for (int i = 0; i <=A; i++)
{
    Console.WriteLine($"{A}, {B} -> {Math.Pow(A, B)}");
    break;
}
