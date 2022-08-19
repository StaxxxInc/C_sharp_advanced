// Задайте двумерный массив 
// из целых чисел размера NxN. 
// Укажите два числа,означающие строки, 
// которые нужно поменять местами.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 9 8 7 2
// число 1 -1
// число 2 -3 

// Итог:
// 1 2 7 4
// 5 3 2 9
// 8 4 2 4
// 9 2 7 8


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

int GetI()
{
    Console.Write("Введите количество столбцов = ");
    int i = Convert.ToInt32(Console.ReadLine().ToString());
    return i;
}

int GetJ()
{
    Console.Write("Введите количество строк = ");
    int j = Convert.ToInt32(Console.ReadLine().ToString());
    return j;
}

int GetPosOne()
{
    int PosOne = Convert.ToInt32(Console.ReadLine().ToString());
    return PosOne;
}

int GetPosTwo()
{
    int PosTwo = Convert.ToInt32(Console.ReadLine().ToString());
    return PosTwo;
}


void Change(int[,] matrix, int PosOne, int PosTwo, int column, int line)
{
    int var = 0;
    for (int i = 0; i < column; i++)
    {
        for (int j = 0; j < line; j++)
        {
            //используем переменную var для временного хранения данных из ячеекмассива
            if (j == (PosOne - 1))
            {
                var = matrix[i, PosOne - 1];
                matrix[i, PosOne - 1] = matrix[i, PosTwo - 1];
                matrix[i, PosTwo - 1] = var;

            }
        }
    }
}





int line = 0;
line = GetI();

int column = 0;
column = GetJ();

int[,] matrix = new int[column, line];

FillArray(matrix);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив = ");
PrintArray(matrix);
Console.WriteLine();

Console.WriteLine("Введите первый столбец: ");
int PosOne = GetPosOne();
Console.WriteLine("Введите второй столбец: ");
int PosTwo = GetPosTwo();

//int[,] Changed =  new int[column, line];
Change(matrix, PosOne, PosTwo, column, line);
Console.WriteLine();
Console.WriteLine("Обновленный массив = ");
PrintArray(matrix);



