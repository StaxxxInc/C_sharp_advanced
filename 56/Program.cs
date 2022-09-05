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
	int max = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
    {
		
		for (int j = 0; i < matrix.GetLength(0); j++)
	
		{
			sum = matrix[i,j] + sum;	
		}
			

		if (max > sum)
		{
			max = sum;
			count++;
		}
		
	}
	
	
	return count;
}



int[,] matrix = new int[4, 4];

FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив = ");
PrintArray(matrix);
Console.WriteLine();
FindMore(matrix);



