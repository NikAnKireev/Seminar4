using System;
Console.Clear();

/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {N(num)}");
int sum = 0;

int N (int num)
{
    int sum = 0;
    while (num>0)
 {
    sum +=num%10;
    num /=10;
 }
 return sum;
}