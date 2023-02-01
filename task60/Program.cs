//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

// --------------Начало программы ----------------------

int rows = GetUserNumber("Введите количество строк: ", "Ошибка ввода");
int colums = GetUserNumber("Введите количество столбцов: ", "Ошибка ввода");
int depth = GetUserNumber("Введите высоту массива: ", "Ошибка ввода");

if((rows * colums * depth) > 99)
{  
     Console.WriteLine("Массив будет состоять из неповторяющихся двузначных чисел. Количество элементов не может превышать 99");    
}
else
{
    int[,,] arrayA = GetNewUserArray(rows, colums, depth);
    PrintArray(arrayA);   
}


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

int[,,] GetNewUserArray(int rows, int colums, int depth)
{
    // нужны двузначные, значит создам массив чисел от 10 до 99
    // выбираю случайным образом индекс чтобы выбрать не использованнео число из массива
    // потом вместо этого числа подставляю 0 и переношу его в начало массива, чтобы больше не выбирать индекс среди уже использованных
    
    int[,,] resarray = new int[rows, colums, depth];
    var Rand = new Random();
    int[] arrTwoDigit = CreateArrayTwoDigitDiff();
    int CountArr = arrTwoDigit.Length;
    int step = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int RandIndex = Rand.Next(0, CountArr);
                resarray[i, j, k] = arrTwoDigit[step + RandIndex];

                arrTwoDigit[step + RandIndex] = arrTwoDigit[step];
                arrTwoDigit[step] = 0;
                step++;
                CountArr--;

            }
        }
    }

    return resarray;
}

int[] CreateArrayTwoDigitDiff()
{

    int[] arr = new int[90];

    for(int i = 0; i < 90; i++)
    {
        arr[i] = i + 10;
    }

    return arr;

}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            Console.WriteLine();
            for (int k = 0; k < arr.GetLength(2); k++) 
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }  
            
        }
    }
}