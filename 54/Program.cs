// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8



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



//метод сортировки массива, передает построчно массив для сортировки 
int[,] MasSort(int[,] str)
{
    int[] SubString = new int[str.Length / 4];
    for (int i = 0; i < str.Length / 4; i++)
    {
        for (int j = 0; j < str.Length / 4; j++)
        {
            SubString[j] = str[i, j];

        }
        BubbleSort(SubString);

        //обратная запись из массива сортировки в сгенерированный массив
        for (int j = 0; j < str.Length / 4; j++)
        {
            str[i, j] = SubString[j];

        }

    }

    return str;

}



static int[] BubbleSort(int[] mas)
{
    int temp;
    for (int i = 0; i < mas.Length; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
            {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
            }
        }
    }
    return mas;
}



int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив = ");
PrintArray(matrix);
Console.WriteLine();

MasSort(matrix);

Console.WriteLine("Массив после сортировки = ");
PrintArray(matrix);




