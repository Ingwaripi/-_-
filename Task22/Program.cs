// напишите программу, которая на вход принеммает число (N) 
// и выдает таблицу квадратов чисел от 1 до N
try{
    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0 )
    {
    for (int i = 1 ; i <= n; i++)
        {
            Console.WriteLine($"{i}\t{i*i}");
        }
    }
    else Console.WriteLine("Введено некоректное значение");
}
catch
{
    Console.WriteLine("Введено некоректное значение");
}

//try catch метод исключений