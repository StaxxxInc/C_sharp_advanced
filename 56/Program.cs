// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой 
// строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка



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
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}


int FindMore(int[,] matrix)
{
    int count = 0;
    int sum = 0;
    int min = 0;
    int result = 0;
    for (int i = 0; i < matrix.Length / 4; i++)
    {

        for (int j = 0; j < matrix.Length / 4; j++)
        {
            sum = matrix[i, j] + sum;
        }
        
        count++;

        if (min == 0)
        {
            min = sum;
            result = count;

        }

        if (sum < min)
        {
            min = sum;
            result = count;
        }

        sum = 0;
    }
    return result;
}



int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив = ");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("номер строки с наименьшей суммой элементов: ");
int more = FindMore(matrix);
Console.WriteLine(more);



