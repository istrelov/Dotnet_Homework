//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// --------------Начало программы ----------------------

int rows = GetUserNumber("Введите количество строк: ", "Ошибка ввода");
int colums = GetUserNumber("Введите количество колонок: ", "Ошибка ввода");
int[,] array = GetNewUserArray(rows, colums, 0, 9);

PrintArray(array);
Console.WriteLine();

BubbleSort(array);
PrintArray(array);

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

void BubbleSort(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int temp;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if(arr[i, k] < arr[i, j])
                {                 
                    temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }    
           
        }
    }    
}