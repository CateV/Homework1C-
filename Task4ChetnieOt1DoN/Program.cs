/* Задача 4: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

/*решение без учёта ввода пользователем отрицательных чисел: */

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

/*А это решение с учётом ввода отрицательных чисел или 0 пользователем: 

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int numberToWrite = 1;

if (n > numberToWrite)
{
    while (numberToWrite < n + 1)
    {
        if (numberToWrite % 2 == 0)
        {
            System.Console.WriteLine(numberToWrite);
        }
        numberToWrite++;
    }
}
else
    while (numberToWrite > n - 1)
    {
        if (numberToWrite % 2 == 0)
        {
            System.Console.WriteLine(numberToWrite);
        }
        numberToWrite = numberToWrite - 1;
    }
    */

   /*Владимир, подскажите, пожалуйста, можно ли это (последний вариант) 
    решить как-то ещё короче, чем у меня (в зависимости от того, меньше или больше 1 число N,
     которое вводит пользователь)? Может как-то через модуль?
   ОТВЕТ ПРЕПОДАВАТЕЛЯ:
   А тут лучше оптимизировать:
int numberToWrite = 2;
while (numberToWrite <= n)
{
    System.Console.WriteLine(numberToWrite);
    numberToWrite += 2;
}
Пока не будем отвлекаться на отрицательные числа
    */