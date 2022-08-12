// Напишите программу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек этой четверти (х и у).

Console.Write("Введите номер четверти: ");
int num = Convert.ToInt32(Console.ReadLine());

string GetReange( int num1)
{
    if (num1 == 1) return "x > 0 и y > 0";
    if (num1 == 2) return "x < 0 и y > 0";
    if (num1 == 3) return "x < 0 и y < 0";
    if (num1 == 4) return "x > 0 и y < 0";
    return "Введите корректный номер четверти";
}
string result = GetReange(num);
Console.WriteLine(result);
