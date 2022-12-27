/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

// --------------Начало программы ----------------------

int Number = InitNumberByUser();
TestPalindrom(Number);

//-----------------Описание методов --------------------

static int InitNumberByUser()
{
    int Number = 0;

    while (true)
    {
        Console.Write("Введите пятизначное число: ");

        try
        {
            Number = Convert.ToInt32(Console.ReadLine());
            int NumberAbs = Math.Abs(Number);

            if (NumberAbs < 9999 || NumberAbs > 99999)
                Console.WriteLine("Число должно быть пятизначным");
            else
                break;

        }
        catch (Exception ext)
        {
            Console.WriteLine($"Ошибка ввода {ext.Message}");
        }
    }

    return Number;
}

static void TestPalindrom(int Number)
{
    if (PositionNumberLeft(Number, 1) == PositionNumberLeft(Number, 5) && PositionNumberLeft(Number, 2) == PositionNumberLeft(Number, 4))
         Console.WriteLine($"{Number} -> да"); 
    else   
        Console.WriteLine($"{Number} -> нет"); 

}

static int PositionNumberLeft(int Num, int Position)
{
    int AbsNum = Math.Abs(Num);

    double x = Math.Pow(10, Position);

    while (AbsNum > x)
    {
        AbsNum = AbsNum / 10;
    }

    int result = AbsNum % 10;
    return result;

}