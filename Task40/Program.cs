// Напишите программу которая на вход принемает 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
bool Triangle(int nu1, int nu2, int nu3)
{
    return nu1 < nu2 + nu3 && nu2 < nu1 + nu3 && nu3 < nu1 + nu2;

}
bool result = Triangle(num1, num2, num3);
Console.WriteLine(result?"Является треугольником": "Не является треугольником");

