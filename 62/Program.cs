// Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
/*
void PrintArrayNew()
{
    int n = 4;
    int[,] a = new int[2, 2];
	a = GetSpire(n);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a[i,j]);
        }
        Console.WriteLine();
    }
}


int[,] GetSpire(int n)
{
    var result = new int[n, n];

        Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rand.Next(10, 99);
            for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
            {
                for (j = padding; j < n - padding; j++)
                    result[padding, j] = currentChar;
                for (j = padding; j < n - padding; j++)
                    result[n - padding, j] = currentChar;
                for (i = padding + 2; i < n - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (i = padding + 1; i < n - padding - 1; i++)
                    result[i, n - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (n % 2 != 0 && result[0, 0] == 1)
                result[n / 2, n / 2] = 1;

            return result;

        }

    }

}

Console.WriteLine("Полученный массив: ");
PrintArrayNew();

*/


class Spiral
{
    static void DisplayArray(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++) Console.Write("{0,3} ", a[i, j]);
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a non-negative number (0 - exit): ");

            int n;
            if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;

            Console.WriteLine();

            int[,] a = new int[n, n];

            int i = 0, j = 0;

            int value = 1;

            while (n != 0)
            {
                int k = 0;
                do { a[i, j++] = value++; } while (++k < n - 1);
                for (k = 0; k < n - 1; k++) a[i++, j] = value++;
                for (k = 0; k < n - 1; k++) a[i, j--] = value++;
                for (k = 0; k < n - 1; k++) a[i--, j] = value++;

                ++i; ++j; n = n < 2 ? 0 : n - 2;
            }

            DisplayArray(a);
            Console.WriteLine();
        }
    }
}