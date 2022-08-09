// Напишите программу, которая выводит случайное трехзначное число и
// удаляет вторую чифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 18

int number = new Random().Next(100, 1000);
int num1 = number / 100;
int num2 = number % 10;
int result_num1_num2 = num1 * 10 + num2;

Console.WriteLine($"Вывод двух чисел из числа {number}: {result_num1_num2}");

