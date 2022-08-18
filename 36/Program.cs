// Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.



//  [3, 7, 23, 12] -> 19
//  [-4, -6, 89, 6] -> 0


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


    int SumElements(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
                sum = sum + array[i];
        }
        return sum;
    }



int[] array = CreateArray(6);
Print(array);
int SumElemenst = SumElements(array);
Console.WriteLine("Сумма элементов стоящих на нечётных позициях: " + SumElemenst);
