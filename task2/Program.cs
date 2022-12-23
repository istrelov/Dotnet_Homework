/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Write("Введите первое число: ");
int FirstNumb = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int SecondNumb = int.Parse(Console.ReadLine() ?? "");

int max = FirstNumb;

if(SecondNumb > FirstNumb) max = SecondNumb;
    
Console.WriteLine($"a = {FirstNumb} b = {SecondNumb} -> max = {max}");