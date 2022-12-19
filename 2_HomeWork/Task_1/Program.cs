/*
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Write a three-digit number");
string n = Console.ReadLine();
if (n.Length == 3)
{
    Console.WriteLine(n[n.Length - 2]);
}
else
    Console.WriteLine("Error: Please write a three-digit number!");