//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// --------------Начало программы ----------------------

int rows = GetUserNumber("Введите количество строк: ", "Ошибка ввода");
int colums = GetUserNumber("Введите количество колонок: ", "Ошибка ввода");
int[,] array = GetNewUserArray(rows, colums, 0, 9);

int rowsnumber = GetUserNumber("Введите номер строки: ", "Ошибка ввода");
int columsnumber = GetUserNumber("Введите номер колонки: ", "Ошибка ввода");

PrintArray(array);
PrintResult(rowsnumber, columsnumber, array);

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

void PrintResult(int rowsnumber, int columsnumber, int [,] arr)
{   
    //вывожу значение по позиции, а не по индексу
    if(rowsnumber > arr.GetLength(0) || columsnumber > arr.GetLength(1))
    {
        Console.Write($"{rowsnumber}{columsnumber} -> такого числа в массиве нет");    
    }
    else
    {
        Console.Write($"{rowsnumber}{columsnumber} -> {arr[rowsnumber-1, columsnumber-1]}");          
    }
}