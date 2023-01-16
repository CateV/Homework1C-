/*  Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}
else if (number3>max)
{
    max = number3;
}
System.Console.WriteLine($"Максимальным из 3-х введённых Вами чисел является число {max}");
/* я правильно понимаю, что здесь не имеет смысла проверять, 
не повторяется ли максимальное число (к примеру,пользователь ввёл 2,8,8), 
так как результат от этого не изменится (и при 2, 5, 8 max = 8, и при 2, 8, 8 max =8), 
а определять, сколько раз повторяется максимальное число, нас не просили? */
