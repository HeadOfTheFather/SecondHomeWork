/*
Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да
*/
Console.WriteLine("Write the number");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("Correct!");
}
else
    Console.WriteLine("Wrong!");