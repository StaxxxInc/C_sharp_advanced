//  Задайте массив заполненный случайными 
//  положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество 
//  чётных чисел в массиве.

//  [345, 897, 568, 234] -> 2



//метод создания и заполнения массива данных
int[] CreateArray(int count)
{
    int[] array = new int[count];              // обьявление массива
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)  // заполнение массива
    {
        array[i] = rand.Next(100, 999);
    }
    return array;
}

// метод проверки на четность числа
int InspectNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }

    return count;
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


int[] array = CreateArray(10);
Print(array);
int GoodNumbers = InspectNumbers(array);
Console.WriteLine(" Четных элементов в массиве: " + GoodNumbers);

