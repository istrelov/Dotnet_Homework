/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/

// --------------Начало программы ----------------------

Console.Clear();

int[] arr = new int[8];
FillArray(arr);
PrintResult(arr);

//-----------------Описание методов --------------------

void FillArray(int[] arr)
{
    int length = arr.Length;

    Console.WriteLine($"Введите {length} элементов массива: ");

    for(int i = 0; i < length; i++)
    {
        arr[i] = InitUserNumber($"{i+1}: ", "Ошибка ввода числа");
    }
}

int InitUserNumber(string Message, string ErrorMessage)
{
    Console.Write(Message);

    while(true)
    {
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int UserNumber);

        if(IsCorrect) 
            return UserNumber;

        Console.WriteLine(ErrorMessage);    
    }
}

void PrintResult(int[] arr)
{
    PrintArray(arr);
    Console.Write(" -> [");  
    PrintArray(arr);
    Console.Write("]");  
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    
    for(int i = 0; i < length; i++)
    {   
        if(i != 0) Console.Write(",");
        Console.Write(arr[i]);
    }
    
}
