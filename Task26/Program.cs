// Напишите программу которая на вход принемает число,
// на выходе показывает количестиво цифр

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int DigitNumber(int numbers)
{
    int i = 0;
    while (num > 0)
    {
        num = num / 10;
        i++;
        
    }
    return i;
}
int result = DigitNumber(num);
Console.WriteLine(result);