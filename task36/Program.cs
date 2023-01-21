//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// --------------Начало программы ----------------------

int size = GetUserNumber("Введите длину массива: ", "Ошибка ввода");
int[] array = GetNewRandomArray(size, -999, 999);
int ResSum = SumNotEvenArray(array, size);

PrintResult(array, ResSum);

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

int SumNotEvenArray(int[] array, int size)
{
    int sum = 0;

    /*немного запутался с четными и не четными
    принимаю что второй элемент массива имеет нечетную позицию (1)
    это подходит под ожидаемый результат из примеров
    [3, 7, 23, 12] -> 19
    -4, -6, 89, 6] -> 0*/

    for(int i = 1; i < size; i+=2)
    {
        sum += array[i];    
    }

    return sum;

}

void PrintResult(int[] array, int sum)
{
    Console.WriteLine($"[{String.Join(", ", array)}] -> {sum}");
}

