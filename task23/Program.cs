/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

// --------------Начало программы ----------------------

Console.Clear();
int N = 0;

InitNumberByUser(ref N);
PrintPowByN(N);

//-----------------Описание методов --------------------

static void InitNumberByUser(ref int N)
{
    while (true)
    {
        Console.Write($"Введите число N больше 1: ");
        try
        {
            N = Convert.ToInt32(Console.ReadLine());

            if (N < 1)
            {
                Console.WriteLine($"Ошибка ввода N должен быть больше 1!");    
            }
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}");
        }
    }
}

static void PrintPowByN(int N)
{
    int i = 1;
    double result = 0;
    
    Console.Write($"{N} -> ");

    while (i < N)
    {
        result = Math.Pow(i, 3);
        i++;
        Console.Write($"{result}, ");
    }

    result = Math.Pow(N, 3);
    Console.Write($"{result}");
}
