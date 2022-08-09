// Напишите программу, которая принемает на вход два числа и проверяет,
// является ли одно число квадратом второго.

// 5,25 -> да
// -4,16 -> да

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите первое число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.Write("да");

}
else 
{
    Console.Write("нет");
}