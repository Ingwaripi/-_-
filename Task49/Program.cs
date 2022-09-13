// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначальн

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // Столбцы col
        {
            matrix[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {


        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3},");
            else Console.Write($"{matrix[i,j], 3}");
        }
        Console.WriteLine("]");
    }
    
}

void ChangeEvenIndxPov (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2D = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(array2D);
ChangeEvenIndxPov(array2D);
Console.WriteLine();
PrintMatrix(array2D);