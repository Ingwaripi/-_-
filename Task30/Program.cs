// Напишите программу которая выводит массив и 8 элиментов
// заполненый нулями и единицами в рандомном порядке

int[] gren ()
{
    int[] array = new int[8];
    for (int i = 0; i <= 7; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
int[] array = gren();

for (int i = 0; i <=7; i++)
{
    Console.Write($"{array [i]}, ");
}
