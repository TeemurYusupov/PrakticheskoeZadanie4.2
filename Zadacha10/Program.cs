// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8

Console.Clear();
Console.Write("Введите трёхзначное число:  ");
int n = Convert.ToInt32(Console.ReadLine());
int y = (n % 100 - n % 10) / 10;
Console.WriteLine($"{y}");
