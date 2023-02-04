//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от M до N.


// --------------Начало программы ----------------------

int M = GetUserNumber("Введите значение M: ", "Ошибка ввода");
int N = GetUserNumber("Введите значение N: ", "Ошибка ввода");

Console.Write($"M = {M}; N = {N} -> '"); 
PrintNaturalNum(M, N);
Console.Write("'"); 

//-----------------Описание методов --------------------

int GetUserNumber(string Mess, string ErrorMess)
{
    Console.WriteLine(Mess);
    while(true)
    {
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int num);

        if (IsCorrect && num > 0)
            return num;

        Console.WriteLine(ErrorMess);
    }

}

void PrintNaturalNum(int M, int N)
{
    if(M >= N)
    {
        string end = N == M ? "" : ", ";
        Console.Write($"{M}{end} "); 
        M--;
        PrintNaturalNum(M, N);       
    }

}