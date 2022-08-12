//ЗАДАЧ 17. Напишите программу, которая принемает на вход 
// координаты точки (X и Y), причем х не равно 0,
// у не равен 0 и выдает номер четверти плоскости, 
// в которой находиться эта точка.

Console.WriteLine("Введите координаты точки : ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
 Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// 1 Способ.
// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("ВВедены неверные координаты");

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "ВВедены неверные координаты";
}
string result = GetQuarter(x, y);
Console.WriteLine(result);
