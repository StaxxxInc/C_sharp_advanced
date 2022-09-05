	// Сформируйте трёхмерный массив из неповторяющихся 
	// двузначных чисел. Напишите программу, 
	// которая будет построчно выводить массив, 
	// добавляя индексы каждого элемента.

	// массив размером 2 x 2 x 2

	// 12(0,0,0) 22(0,0,1)
	// 45(1,0,0) 53(1,0,1)



	void FillArray(int[,] matr)
	{
		for (int i = 0; i < matr.GetLength(0); i++)
		{
			for (int j = 0; j < matr.GetLength(1); j++)
			{
				matr[i, j] = new Random().Next(10, 99);
			}
		}
	}

	void PrintArray(int[,] matr, string[] pos)
	{
		for (int i = 0; i < matr.GetLength(0); i++)
		{
			for (int j = 0; j < matr.GetLength(1); j++)
			{
				Console.Write($"{matr[i, j]} " + $"{pos[i]} ");
			}
			Console.WriteLine();
		}
	}





	int[,] matrix = new int[2, 2];
	FillArray(matrix);

	string[] bottom = new string[] { "(0,0,0)", "(0,1,0)", "(0,0,1)", "(0,1,1)"};
	PrintArray(matrix, bottom);

	string[] top = new string[] { "(1,0,0)", "(1,1,0)", "(1,0,1)", "(1,1,1)"};	
	PrintArray(matrix, top);
	

