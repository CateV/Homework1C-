/*  Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7, min = 5
a = -9 b = -3 -> max = -3, min = -9 */

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;
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

/*Владимир, подскажите, пожалуйста, 
в правильном ли месте я впервые объявила min и max, всё ли с ними в порядке? Спасибо */
