// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76


//метод создания и заполнения массива данных
int[] CreateArray(int count)
{
    int[] array = new int[count];              // обьявление массива
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)  // заполнение массива
    {
        array[i] = rand.Next(-100, 100);
    }
    return array;
}

void Print(int[] array)
{
    int size = array.Length;
    Console.Write(" [ ");
    for (int i = 0; i < size; i++)
    {
        if (i == size - 1)
        {
            Console.Write($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i] + ","} ");
        }
    }
    Console.Write(" ] ");
}

int[] MinMaxCheck(int[] array)
{
    int min = 0;
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else
            min = array[i];
    }
    return new int[] { max, min };
}

int Differenc(int[] array)
{
    int Diff = 0;
    Diff = array[0] - array[1];
    return Diff;
}



int[] array = CreateArray(6);
Print(array);
Console.WriteLine();
int[] MinMax = MinMaxCheck(array);
Console.WriteLine("Максимальный : " + MinMax[0]);
Console.WriteLine("Минимальный  : " + MinMax[1]);

int Diff = Differenc(MinMax);
Console.WriteLine("Разница между максимальным");
Console.WriteLine("и минимальных элементами массива : " + Diff);

