// Напишите программу которая выводит случайное число  из отрезка [10, 99] 
// и показать наибольшую цтфру числа
// 78 -> 9
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100); // 10, 99 + 1
//Console.WriteLine($"Случайное число из диапазона 10, 99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// if (firstDigit == secondDigit ) Console.WriteLine("Цифры равны");
// else if (firstDigit > secondDigit ) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} => {secondDigit}");
// //          if                                    else
string result = firstDigit == secondDigit ? "Цифры равны" : firstDigit > secondDigit ? firstDigit : secondDigit; // тернареый оператор
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");