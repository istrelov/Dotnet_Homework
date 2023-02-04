//Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.

// --------------Начало программы ----------------------

int M = GetUserNumber("Введите число M: ", "Ошибка ввода");
int N = GetUserNumber("Введите число N: ", "Ошибка ввода");

Console.WriteLine($"M = {M}; N = {N} -> ");
Console.Write(GetSum(M, N));

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

int GetSum(int M, int N)
{
    if(N == 1) return M;
    else 
    {   
         
        return GetSum(M + N, N-1);
    }
}