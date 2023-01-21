//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// --------------Начало программы ----------------------

int size = GetUserNumber("Введите длину массива: ", "Ошибка ввода");
int[] array = GetNewRandomArray(size, 100, 999);
int ResCount = CountEvenArray(array);

PrintResult(array, ResCount);

//-----------------Описание методов --------------------

int GetUserNumber(string Mess, string ErrorMess)
{
    Console.WriteLine(Mess);  
    while(true)
    {
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int num);   

        if(IsCorrect)
            return num;
        
        Console.WriteLine(ErrorMess); 
    } 

}

int[] GetNewRandomArray(int size, int min, int max)
{
    int[] myArr = new int[size];
    var rnd = new Random();
    for(int index = 0; index < size; index++)
    {
        myArr[index] = rnd.Next(min, max + 1);   
    }
    return myArr;
}

int CountEvenArray(int[] array)
{
    int count = 0;

    foreach (int item in array)
    {
        if(item % 2 == 0) count++;    
    }

    return count;

}

void PrintResult(int[] array, int ResCount)
{
    Console.WriteLine($"[{String.Join(" ", array)}] -> {ResCount}");
}

