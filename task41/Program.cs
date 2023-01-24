//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// --------------Начало программы ----------------------

int num = GetUserNumber("Введите длину массива M", "Ошибка ввода");
int[] array = GetNewUserArray(num);
int PositiveCount = PositiveCountForArray(array);

PrintResult(PositiveCount, array);

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

int[] GetNewUserArray(int num)
{
    int[] array = new int[num];

    Console.WriteLine("");

    for(int i = 0; i < num; i++)
    {
        array[i] = GetUserNumber($"Введите {i+1}: ", "Ошибка ввода");           
    }

    return array;
}

int PositiveCountForArray(int[] array)
{
    int count = 0;

    foreach (int item in array)
    {
        if(item > 0)  count++;  
    }
    return count;
}

void PrintResult(int PositiveCount, int[] arr)
{
    Console.WriteLine($"{String.Join(" ", array)} -> {PositiveCount}");
}