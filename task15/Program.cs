/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

// --------------Начало программы ----------------------
int NumberDay = InitNumberDayUser();

if(NumberDay > 5)
    Console.WriteLine($"{NumberDay} -> да");
else
    Console.WriteLine($"{NumberDay} -> нет");   


//-----------------Описание методов --------------------
int InitNumberDayUser()
{
    int Num = 0;

    while(true)
    {
        Console.Write("Введите номер дня недели: ");

        try
        {
            Num = Convert.ToInt32(Console.ReadLine());

            if((Num < 1) || (Num > 7))
                Console.WriteLine("Число не соответствует номеру недели");    
            else
                break;
        }
        catch(Exception exc)
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}");
        }
    }

    return Num;
}
