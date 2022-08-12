// Напишите программу, которая принемает на вход координаты двух точек,
// и находит расстояние между ними  в 2D пространстве.
// Math.Sqrt найти квадат числа
// Math.Round сокращение числа от запятой
double Distance( int xc1, int yc1, int xc2, int yc2)
{
    // double dist = Math.Sqrt((xc2 - xc1)*(xc2 - xc1)+(yc1 - yc2)*(yc1 - yc2));
    // return dist;
    return Math.Sqrt((xc2 - xc1)*(xc2 - xc1)+(yc1 - yc2)*(yc1 - yc2));
}
Console.Write("Введите первое значение x : ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое значение y : ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение x : ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе значение y : ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, y1, x2, y2 );
Console.WriteLine(Math.Round(res,2));


