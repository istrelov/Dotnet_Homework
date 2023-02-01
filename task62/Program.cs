//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// --------------Начало программы ----------------------

int rows = GetUserNumber("Введите количество строк: ", "Ошибка ввода");
int cols = GetUserNumber("Введите количество столбцов: ", "Ошибка ввода");
int startnum = GetUserNumber("Введите первое число: ", "Ошибка ввода");

int[,] array = GetNewUserArray(rows, cols, startnum);
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

int[,] GetNewUserArray(int rows, int cols, int minvalue)
{
    //хороший алгоритм с объяснением как не решать в лоб и как заполнить матрицу любого размера
    //https://www.haikson.com/programmirovanie/zapolnenie-dvumernoj-matritsyi-po-spirali/

    int[,] resarray = new int[rows, cols];

    int IndexRowBegin = 0, IndexRowEnd = 0, IndexColBegin = 0, IndexColEnd = 0;
    
    int i = 0;
    int j = 0;


    while (minvalue <= rows * cols)
    {

        resarray[i, j] = minvalue;

        if (i == IndexRowBegin && j < (cols - IndexColEnd - 1))
        {
            //Если верхняя сторона прямоугольника и не достигла правой стороны, то двигаемся вправо: j++
            j++;
        }           
        else if (j == cols - IndexColEnd - 1 && i < rows - IndexRowEnd - 1)
        {
            //Если на правой стороне прямоугольника и не достигли нижней стороны, то двигаемся вниз: i++
            i++;
        }
            
        else if (i == rows - IndexRowEnd - 1 && j > IndexColBegin)
        {
            //Если  на нижней стороне прямоугольника и не достигли левой стороны, то двигаемся влево: j--
            j--;
        }
            
        else
        {
            //Иначе двигаемся вверх: i--
            i--;
        }

            /*В конце же каждого прохода проверяем, завершился ли прямоугольник и стои ли начинать прочерчивать новый - меньший:
            Если мы находимся на второй строке
            Если мы находимся на первом столбце
            И, в случае, если чертим не прямоугльник, а вертикальную линию, если первая строка не равна последней
            Тогда увеличиваем отступы от краев первого прямоугольника: */

            if ((i == IndexRowBegin + 1) && (j == IndexColBegin) && (IndexColBegin != cols - IndexColEnd - 1))
            {
                IndexRowBegin++;
                IndexRowEnd++;
                IndexColBegin++;
                IndexColEnd++;
            }
            
        minvalue++;

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
            Console.Write($"{String.Format("{0:00}", arr[i, j])} ");
        }
    }
}