//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// --------------Начало программы ----------------------

int rows = GetUserNumber("Введите количество строк матрицы A: ", "Ошибка ввода");
int columsA = GetUserNumber("Введите количество колонок матрицы A (строк матрицы B): ", "Ошибка ввода");
int columsB = GetUserNumber("Введите количество столбцов матрицы B: ", "Ошибка ввода");

int[,] arrayA = GetNewUserArray(rows, columsA, 0, 9);
int[,] arrayB = GetNewUserArray(columsA, columsB, 0, 9);

Console.WriteLine();
Console.WriteLine("Матрица A");
PrintArray(arrayA);

Console.WriteLine("");
Console.WriteLine("Матрица B");
PrintArray(arrayB);

int[,] arrayC = GetProdArray(arrayA, arrayB, rows, columsA, columsB);

Console.WriteLine("");
Console.WriteLine("Произведение, матрица C");
PrintArray(arrayC);

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
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetProdArray(int [,] arrA, int [,] arrB, int rowsA, int columsA, int columsB)
{
    int[,] resarray = new int[rowsA, columsB];

    for (int i = 0; i < rowsA; i++) //каждая строка А
    {
        for (int j = 0; j < columsB; j++) // каждый столбец B
        {
            for (int k = 0; k < columsA; k++)
            {
                resarray[i, j] += arrA[i, k] * arrB[k, j];
            }      
        } 
    }
        
    return resarray;
}