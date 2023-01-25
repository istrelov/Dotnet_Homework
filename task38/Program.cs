//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// --------------Начало программы ----------------------

int size = GetUserNumber("Введите длину массива: ", "Ошибка ввода");
float[] array = GetNewRandomArray(size, -999, 999);
float res = FindDifferentBetweenMaxArray(array);

PrintResult(array, res);

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

float[] GetNewRandomArray(int size, int min, int max)
{
    float[] myArr = new float[size];
    var rnd = new Random();
    for(int index = 0; index < size; index++)
    {
        myArr[index] = rnd.Next(min, max + 1);   
    }
    return myArr;
}

float FindDifferentBetweenMaxArray(float[] array)
{
    float min = array[0];
    float max = array[0];

    foreach (var item in array)
    {
        if(item < min) min = item;   
        if(item > max) max = item; 
    }
    
    float res = max - min;
    return res;

}

void PrintResult(float[] array, float res)
{
    Console.WriteLine($"[{String.Join(" ", array)}] -> {res}");
}

