//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

// --------------Начало программы ----------------------

int rows = GetUserNumber("Введите значение m ", "Ошибка ввода");
int colums = GetUserNumber("Введите значение n ", "Ошибка ввода");
float [,] array = GetNewUserArray(rows, colums, -9, 9);

PrintArray(array);
//-----------------Описание методов --------------------

int GetUserNumber(string Mess, string ErrorMess)
{
    Console.WriteLine(Mess);
    while (true)
    {
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int num);

        if (IsCorrect && num > 1)
            return num;

        Console.WriteLine(ErrorMess);
    }

}

float[,] GetNewUserArray(int rows, int colums, int minvalue, int maxvalue)
{
    float[,] resarray = new float[rows, colums];
    var Rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            resarray[i, j] = (float)Rand.NextDouble() * Rand.Next(minvalue, maxvalue+1);
        }
    }

    return resarray;
}

void PrintArray(float [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //округление до сотых]
            Console.Write($"{Math.Round(arr[i, j],2)} ");
        }
        Console.WriteLine();
    }
}