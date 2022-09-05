// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49




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




int[,] MatrixProduct (int[,] matrixOne, int[,] matrixTwo)
{
	int[,] matrixResult = new int[4, 4];
		for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
		
		for (int j = 0; i < matrixOne.GetLength(0); j++)
	
		{
			matrixResult[i,j] = matrixOne[i,j] * matrixTwo[i,j];			
		}
	}
	return matrixResult;
} 





int[,] matrixOne = new int[4, 4];

FillArray(matrixOne);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив 1 = ");
PrintArray(matrixOne);
Console.WriteLine();


int[,] matrixTwo = new int[4, 4];

FillArray(matrixTwo);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив 2 = ");
PrintArray(matrixTwo);
Console.WriteLine();


int[,] matrixResult = MatrixProduct(matrixOne, matrixTwo);
Console.WriteLine("Произведение двух массивов равно = ");
PrintArray(matrixResult);
Console.WriteLine();


