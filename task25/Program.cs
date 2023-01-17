/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

// --------------Начало программы ----------------------

Console.Clear();

int PowA = InitUserNumber("Введите основание степени: ", "Ошибка ввода числа");
int PowB = InitUserNumber("Введите показатель степени: ", "Ошибка ввода числа");

int PowResult = PowResultUserNumber(PowA, PowB);

PrintPowResult(PowA, PowB, PowResult);

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

int PowResultUserNumber(int PowA, int PowB)
{
    int res = PowA;

    for(int i = 1; i < PowB; i++)
    {
        res = res * PowA;    
    }

    return res;
}

void PrintPowResult(int PowA, int PowB, int PowResult)
{
    Console.WriteLine($"{PowA},{PowB} -> {PowResult}");
}