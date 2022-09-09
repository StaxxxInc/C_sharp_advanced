// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30




(int, int) GetIJ()
{

    Console.Write("Введите значение M = ");
    int i = Convert.ToInt32(Console.ReadLine().ToString());
    Console.Write("Введите значение N = ");
    int j = Convert.ToInt32(Console.ReadLine().ToString());
    (int, int) ij = (i, j);
    return ij;
}

int Amount(int M, int N)
{
	int result = 0;
	if (M>N)
	result = M - N + 1;
	else 
	result = N - M + 1;
	return result;
}


int[] MakeArray (int array)
{
	int[] arr = new int[array];
    return arr;
}



int SumArray (int[] NewArray, int M, int N)
{
	 int sum = 0;
	if(M > N)
	{
	for (int i = N; i <= M; i++)
		{	
			sum = sum + i;
		}
	}
	else
	for (int i = M; i <= N; i++)
		{	
			sum = sum + i;
		}
	return sum;
}



void PrintArray(int[] NewArray, int M, int N)
{
   
    Console.Write('"');

    if (M > N)
    {
        for (int i = N; i <= M; i++)
        {
            if (i < M) 
            {
                Console.Write(i + ", ");
            }
            else 
            Console.Write(i);
        }
    }
    else
        for (int i = M; i <= N; i++)
        {
            if (i < N)  
            {
                Console.Write(i + ", ");
            }
            else 
            Console.Write(i);
        }

    Console.Write('"');

}



(int, int) ij = GetIJ();

int M = 0;
M = ij.Item1;

int N = 0;
N = ij.Item2;

int amount = Amount(M, N);

int[] NewArray = MakeArray(amount);

PrintArray(NewArray, M, N);
Console.WriteLine();
Console.Write("сумма натуральных элементов в промежутке от M до N: ");
int sum = SumArray(NewArray, M, N);
Console.Write(sum);