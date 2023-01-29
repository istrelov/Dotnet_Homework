//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

// --------------Начало программы ----------------------

int rows = GetUserNumber("Введите количество строк: ", "Ошибка ввода");
int colums = GetUserNumber("Введите количество колонок: ", "Ошибка ввода");
int[,] array = GetNewUserArray(rows, colums, 0, 9);

PrintArray(array);
Console.WriteLine();

float[] resarray = AverageArray(array); 
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", resarray)}");

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

float[] AverageArray(int[,] arr)
{
    int countcolarr = arr.GetLength(1);
    int countrowarr = arr.GetLength(0);

    float[] resarr = new float[countcolarr];
    
    for (int col = 0; col < countcolarr; col++)
    {

        float sum = 0;
        for (int row = 0; row < countrowarr; row++)
        {
            sum+= arr[row, col];    
        }

        resarr[col] = (sum / (float)countcolarr);
    }

    return resarr;
}