// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 10);
        }
    }
}

int GetI()
{
    Console.Write("Введите количество строк = ");
    int i = Convert.ToInt32(Console.ReadLine().ToString());
    return i;
}

int GetJ()
{
    Console.Write("Введите количество столбцов = ");
    int j = Convert.ToInt32(Console.ReadLine().ToString());
    return j;
}

int j = 0;
j = GetJ();

int i = 0; 
i = GetI();

int[,] matrix = new int[i, j];
FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив = ");
PrintArray(matrix);
Console.WriteLine();
