/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

Console.Write("Введите число ");
int LastNumb = int.Parse(Console.ReadLine() ?? "");
int index = 1;

if (LastNumb < index)
{
    Console.Write("Число должно быть больше или равно 1");
}
else
{
    bool FirstPrint = true;
    while (index <= LastNumb)
    {
        if((index%2) == 0)
        {
            if (FirstPrint)
            {
                Console.Write(index);
                FirstPrint = false;
            }
            else
            {
                Console.Write($", {index}");
            }
        }

        index++;
    }
}