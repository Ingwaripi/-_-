// 42. Напишите программуб которая будет преобразовывыть
//  десятичное число в двоичное

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result = default;
int mult = 1;
while (num > 0)
{
    result += num % 2 * mult;
    num /= 2;
    mult *= 10;
}
Console.WriteLine(result);