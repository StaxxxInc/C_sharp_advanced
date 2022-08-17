//  Напишите метод, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



// метод получения числа
string GetNumber()
{
    Console.Write("Введите номер = ");
    string Number = Console.ReadLine();
    return Number;
}

// метод получения суммы
int MakeSumm(string Num)
{
	
    int result = 0;
    int a = 0;

    for (int i = 0; i < Num.Length; i++)
    {
        a = Convert.ToInt32(Num[i].ToString());
        result = result + a;
    }

    return result; 
}

void Print(string number, int result)
{
    Console.Write("Сумма чисел " + number + " = " + result);
}

string Number = GetNumber();
int ResultSum = MakeSumm(Number);
Print(Number, ResultSum);

