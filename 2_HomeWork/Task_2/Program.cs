/*
Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Write a three-digit number");
string n = Console.ReadLine();
if (n.Length < 3)
{
    Console.WriteLine("Error: There is not a third sign");
}
else
        Console.WriteLine(n[2]);