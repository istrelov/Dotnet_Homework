/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

// --------------Начало программы ----------------------
Console.Clear();

int Num = InitNumberByUser();
PrintSecondNumber(Num);

//-----------------Описание методов --------------------
static int  InitNumberByUser()
{
    int Num;

    while (true)
    {
        Console.Write("Введите трехзначное число: ");

        try
        {
            Num = Convert.ToInt32(Console.ReadLine());
            
            if (Math.Abs(Num) > 99 && (Math.Abs(Num) < 1000))
                break;
            else
                Console.WriteLine("Число должно быть трехзначным!!!");

        }
        catch(Exception exc)
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}");
        }
    }

    return Num;
}

static void PrintSecondNumber(int Num)
{
    int result = Num / 10 % 10;
    Console.WriteLine($"{Num} -> {result}");
}