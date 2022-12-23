/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

// --------------Начало программы ----------------------
Console.Clear();

int Num = InitNumberByUser();

int RightThirdNumber = -1;
int LeftThirdNumber = -1;

FindThirdNumber(ref RightThirdNumber, ref LeftThirdNumber, Num);
PrintResult(RightThirdNumber, LeftThirdNumber, Num);

//-----------------Описание методов --------------------

static int InitNumberByUser()
{

    int Num = 0;

    while (true)
    {
        Console.Write("Введите число: ");

        try
        {
            Num = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch(Exception exp)
        {
            Console.WriteLine($"Ошибка ввода! {exp.Message}");
        }
    }
    return Num;
}

static void FindThirdNumber(ref int RightThirdNumber, ref int LeftThirdNumber, int Num)
{
    int AbsNum = Math.Abs(Num);

    if(AbsNum < 99) return;

    RightThirdNumber = AbsNum / 100 % 10;

    while (AbsNum > 999)
    {
        AbsNum = AbsNum / 10;    
    }

    LeftThirdNumber = AbsNum % 10;

}

static void PrintResult(int RightThirdNumber, int LeftThirdNumber, int Num)
{
    if (RightThirdNumber == -1)
        {
            Console.WriteLine($"{Num} -> третьей цифры нет");
        }
    else
    {
        Console.WriteLine($"{Num} -> справа {RightThirdNumber}, слева {LeftThirdNumber}");    
    }
}