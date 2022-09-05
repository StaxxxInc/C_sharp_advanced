// Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// задача посложнее - вводить позицию в одну строку. //
// символ-разделитель - запятая //


//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4

//  1,7 -> такого числа в массиве нет

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

int GetPosVert()
{
    // Console.Write("Введите позицию по вертикали = ");
    int PosVert = Convert.ToInt32(Console.ReadLine().ToString());
    return PosVert;
}

int GetPosHor()
{
    // Console.Write("Введите позицию по горизонтали = ");
    int PosHor = Convert.ToInt32(Console.ReadLine().ToString());
    return PosHor;
}

void FindElement(int Vert, int Hor, int[,] matrix, int i, int j)
{
    int result = 0;
    if (Vert < i && Hor < j)
    {
        result = matrix[Vert - 1, Hor - 1];
        Console.WriteLine("В указанных координатах найдено : " + result);
    }
    else
        Console.WriteLine("такого числа в массиве нет ");

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

Console.WriteLine("Введите позицию элемента по горизонтали: ");

int PosHor = GetPosHor();
Console.WriteLine("Введите позицию элемента по вертикали: ");
int PosVert = GetPosVert();
FindElement(PosHor, PosVert, matrix, i, j);

