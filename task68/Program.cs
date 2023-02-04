//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// --------------Начало программы ----------------------

int M = GetUserNumber("Введите число M: ", "Ошибка ввода");
int N = GetUserNumber("Введите число N: ", "Ошибка ввода");

Console.WriteLine($"M = {M}; N = {N} -> A({M}, {N}) = ");
Console.Write(GetAnkerman(M, N));

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

int GetAnkerman(int M, int N)
{
    if(M == 0) return N + 1;
    else if (N == 0) return GetAnkerman(M - 1, 1);
    else return GetAnkerman(M - 1, GetAnkerman(M, N - 1));

}