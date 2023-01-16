/* Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int numberToWrite = 1;
while (numberToWrite < n + 1)
{
    if (numberToWrite % 2 == 0)
    {
        System.Console.WriteLine(numberToWrite);
    }
    numberToWrite++;
}

if (number % 2 == 0)
{
    System.Console.WriteLine($"{number}");
}