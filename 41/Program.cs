// Двумерные массивы и рекурсия

// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


string GetArray()
{
    Console.WriteLine("Введите массив: ");
    string s = Console.ReadLine();
    return s;
}

// метод для определения количества элементов в массиве
int LenghtArray(string s)
{
    int i = 0;
    int LenghtArr = 1;
    while (i < s.Length)
    {
        
        if (s[i] == ',')
        {
            LenghtArr++;
        }
        i++;
    }

    return LenghtArr;
}


//вынимаем необходимые данные из полученного массива
int[] InceptArray(string s, int LenghtArr)
{

    int IndexOfSymbol = 0; // необходим для запоминания местоположения в строке
    int IndexOfSymArr = 0; // индекс элемента ',' в массиве
    int i = 0; // счетчик элементов
    int AmountOfElements = 1; // сколько символов из строки берем для массива (от запятой до запятой)

    string g; //переменная для подстроки

    int[] array = new int[LenghtArr];


    while (i < s.Length)
    {

        if (s[i] == ',')
        {
            g = s.Substring(IndexOfSymbol, AmountOfElements - 1);

            array[IndexOfSymArr] = Convert.ToInt32(g.ToString());
            IndexOfSymbol = i + 1;
            IndexOfSymArr++;
            AmountOfElements = 0;
        }
        AmountOfElements++;

        //когда доходим до последнего элемента в строке работает это условие
        if (i == (s.Length - 1))
        {
            g = s.Substring(IndexOfSymbol, AmountOfElements - 1);
            array[IndexOfSymArr] = Convert.ToInt32(g.ToString());
            IndexOfSymArr++;
        }
        i++;

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


int AboveZero(int[] array, int AboveZer, int i, int LenghtArr) 
{
 if (array[i] > 0)
    AboveZer++;

    i++;
    //крутимся в рекурсии пока мы внутри массива
    if (i != LenghtArr)
    {
        return AboveZero(array, AboveZer, i, LenghtArr);
    }
    return AboveZer;  
}




string s = GetArray();

int LenghtArr = LenghtArray(s);
int[] array = InceptArray(s, LenghtArr);
Print(array);
int AboveZer = 0;
AboveZer = AboveZero(array, AboveZer, 0, LenghtArr);
Console.WriteLine("Больше нуля: " + AboveZer);



