/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

Console.Write("Введите первое число: ");
int FirstNumb = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int SecondNumb = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье число: ");
int ThurdNumb = int.Parse(Console.ReadLine() ?? "");

int MaxNumb = FirstNumb;

if(SecondNumb > MaxNumb) MaxNumb = SecondNumb;
if(ThurdNumb > MaxNumb) MaxNumb = ThurdNumb;

Console.WriteLine($"{FirstNumb}, {SecondNumb}, {ThurdNumb} -> {MaxNumb}");   