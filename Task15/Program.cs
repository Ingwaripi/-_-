// Напишите программу которая на фход принемает число А,
// на выход выдает сумму чисел

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int sum = default; //0

// for (int i = 1; i <= num; i++)
// {
//     sum = sum + i;
//     //sum +=i
// }

//Console.WriteLine($"сумма чисел от 1 до {num} равна {sum}");

int SumNumbers(int numbers)
{
    int sum = 0;
    for (int i = 1; i <= numbers; i++)
    {
        sum = sum + i;
    }   //sum +=i
        return sum;
    
}
if ( num>0 ){
    int result = SumNumbers(num);
    Console.WriteLine($"сумма чисел от 1 до {num} равна {result}");
}
else 
{
    Console.WriteLine("некоректный ввод, требуется положительное число");
}