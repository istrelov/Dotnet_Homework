/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

// --------------Начало программы ----------------------

Console.Clear();

int UserNumber = InitUserNumber("Введите целое число: ", "Ошибка ввода числа");
int SumResult = SumResultUserNumber(UserNumber);
Console.WriteLine($"{UserNumber} -> {SumResult}");

//-----------------Описание методов --------------------

int InitUserNumber(string Message, string ErrorMessage)
{
    Console.Write(Message);

    while(true)
    {
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int UserNumber);

        if(IsCorrect) 
            return UserNumber;

        Console.WriteLine(ErrorMessage);    
    }
}

int SumResultUserNumber(int UserNumber)
{
    int sum = 0;
    int AbsUserNumber = Math.Abs(UserNumber);

    while(AbsUserNumber > 0)
    {
        sum = sum + AbsUserNumber % 10;
        AbsUserNumber = AbsUserNumber / 10;
    }

    return sum;
}

void PrintResult(int UserNumber, int SumResult)
{
    Console.WriteLine($"{UserNumber} -> {SumResult}");
}