/*  Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7, min = 5
a = -9 b = -3 -> max = -3, min = -9 */

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (number1 == number2)
{
    System.Console.WriteLine("Введённые Вами числа равны, невозможно выделить максимальное и минимальное");
}
else
{
    if (number1 > number2)
    {
        max = number1;
        min = number2;
    }
    else
    {
        max = number2;
        min = number1;
    }
    System.Console.WriteLine($"Большим из 2-х введённых Вами чисел является число {max}");
    System.Console.WriteLine($"Меньшим - число {min}");
}

/*Владимир, подскажите, пожалуйста:
1)в правильном ли месте я впервые объявила min и max, всё ли с ними в порядке?  
2)можно ли, объявляя max и min в 9-10 строке, присваивать им на старте значение 0? 
3) Или лучше было бы присвоить им на старте значения number1 максу и number2 мину? 
4) можно ли было в 9-10 строчке просто объявить max и min и не присваивать им вообще
никакого начального значения в данном случае (int max; int min;)?

 Спасибо за ответы
*/
