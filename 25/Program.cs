// Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16





int GetNumberA()
{
    Console.Write("Введите A = ");
    int A = Convert.ToInt32(Console.ReadLine().ToString());
    return A;
}

int GetNumberB()
{
    Console.Write("Введите B = ");
    int B = Convert.ToInt32(Console.ReadLine().ToString()); 
    return B;
}

//метод возведения в степень
int Exponention(int A, int B)
{
    int result = 0;
    result = Convert.ToInt32(Math.Pow(A, B));
    return result;
}

//метод вывода на печать
void Print(int result, int A, int B)
{
    Console.Write(A + " в степени " + B + " = " + result);
}


int A = GetNumberA();
int B = GetNumberB();
int result = Exponention(A, B);
Print(result, A, B);
