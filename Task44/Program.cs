﻿// 44 Не используя рекурсию, выведите первый N чисел Фибоначи,
// Первые два числа 0 и 1.

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

void ShowFibonacci (int num)
{
    int num1 = 0;
    int num2 = 1;
    Console.Write(num1+" "+num2+" ");
    for (int i = 0; i <= num; i++)
    {
        int temp = num1 + num2;
        num1 = num2;
        num2 = temp;
        Console.Write(temp+" ");
    }
    Console.WriteLine();
}
ShowFibonacci(num);