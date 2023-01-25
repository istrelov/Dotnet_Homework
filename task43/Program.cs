//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//привожу уравнения к общей точке пересечения. получается формула x = (b2-b1) / k1 - k2
//решим при помощи массивов

// --------------Начало программы ----------------------

double[] arrayK = GetNewUserArray("Введите значения k");
double[] arrayB = GetNewUserArray("Введите значения b");

double[] arrayres = new double[2];
CompureRes(arrayres, arrayK, arrayB);

Console.WriteLine($"Точки пересечения {String.Join(", ", arrayres)}");

//-----------------Описание методов --------------------

double[] GetNewUserArray(string Mess)
{
    double[] array = new double[2];

    Console.WriteLine("");

    for(int i = 0; i < 2; i++)
    {
        array[i] = GetUserNumber($"{Mess} {i+1}: ", "Ошибка ввода");           
    }

    return array;
}

double GetUserNumber(string Mess, string ErrorMess)
{
    Console.WriteLine(Mess);  
    while(true)
    {
        bool IsCorrect = double.TryParse(Console.ReadLine(), out double num);   

        if(IsCorrect)
            return num;
        
        Console.WriteLine(ErrorMess); 
    } 

}

void CompureRes(double[] arrayres, double[] arrayK, double[] arrayB)
{
    arrayres[0] = (arrayB[1] - arrayB[0]) / (arrayK[0] - arrayK[1]);   
    arrayres[1] = (arrayK[0] *  arrayres[0]) + arrayB[0];
}