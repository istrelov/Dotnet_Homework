/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

Console.Write("Введите число ");
int Numb = int.Parse(Console.ReadLine() ?? "");

if(Numb%2 == 0)
{
    Console.WriteLine($"{Numb} -> да");
}
else
{
    Console.WriteLine($"{Numb} -> нет");
}