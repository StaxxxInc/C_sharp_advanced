//  Напишите метод, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


string GetNumber()
{
	
	Console.Write("Введите число = ");
	number = Console.Readline();
	// A = Convert.ToInt32(Console.Readline().ToString()); //
	return number;	
} 

string MakeSumm(string number);
{
	int result = 0;
	int a=0;
	
	for (int i=0; i<Lenght.number; i++)
	{
		a = Convert.ToInt32(number[i]);
		result = result + a;
	}
	return result;
}

void Print(string number, int result)
{
	Console.Write("Сумма чисел "+ number + " = " + result);	
}

String Num = GetNumber();
MakeSumm(Num);
Print();

