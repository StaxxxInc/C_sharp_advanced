// Напишите метод(ы), которай задаёт массив 
// из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


//получаем массив от пользователя
string GetArray()
{
    Console.WriteLine("Введите массив: ");
    string s = Console.ReadLine();
    Console.WriteLine("s : " + s);
    return s;
}

//вынимаем необходимые данные из полученного массива
int[] InceptArray(string s)
{

    int k = 0; // необходим для запоминания местоположения в строке
    int n = 0; // индекс элемента в массиве
    int i = 0; // счетчик элементов
    int v = 0; // сколько символов из строки берем для массива (от запятой до запятой)
    int l = s.Length;
    string g;
    int[] array = new int[8];

    while (i < s.Length)
    {

        if (s[i] == ',')
        {
            g = s.Substring(k, v - 1);
            array[n] = Convert.ToInt32(g.ToString());
            k = i + 1;
            n++;
            v = 0;
        }

        //не знал как по другому выкрутиться тут с отсутвтием запятой вконце ввода массива пользователем 
        if (n == 7)
        {
            v = l - i;
            g = s.Substring(k, v - 1);
            array[n] = Convert.ToInt32(g.ToString());
            n++;
        }
        i++;
        v++;
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

//Работает только с восьмью элементами как по заданию

string s = GetArray();
int[] array = InceptArray(s);
Console.WriteLine(" Ваш массив готов ! ");
Print(array);
