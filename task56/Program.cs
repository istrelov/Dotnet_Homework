//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

// --------------Начало программы ----------------------

int rows = GetUserNumber("Введите количество строк: ", "Ошибка ввода");
int colums = GetUserNumber("Введите количество колонок: ", "Ошибка ввода");
int[,] array = GetNewUserArray(rows, colums, 0, 9);

PrintArray(array);
Console.WriteLine();

int minrow = FindMinSumRow(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов {minrow}");

//-----------------Описание методов --------------------

int GetUserNumber(string Mess, string ErrorMess)
{
    Console.WriteLine(Mess);
    while (true)
    {
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int num);

        if (IsCorrect && num > 0)
            return num;

        Console.WriteLine(ErrorMess);
    }

}

int[,] GetNewUserArray(int rows, int colums, int minvalue, int maxvalue)
{
    int[,] resarray = new int[rows, colums];
    var Rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resarray[i, j] = Rand.Next(minvalue, maxvalue + 1);
        }
    }

    return resarray;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
    }
}

int FindMinSumRow(int[,] arr)
{
    int minind = 0, minsum = arr.GetLength(1) * 9;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }

        if(sum < minsum)
        {
            minsum = sum;
            minind = i;
        }
    }  

    return minind;  

}