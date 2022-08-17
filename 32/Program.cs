//  Напишите программу замена элементов массива: 
//  положительные элементы замените на соответствующие отрицательные, 
//  и наоборот.
/// [-4, -8, 8, 2] -> [4, 8, -8, -2] 



//функция создания и заполнения массива данных
int[] CreateArray(int count)
{
    int[] array = new int[count];              // обьявление массива
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)  // заполнение массива
    {
        array[i] = rand.Next(-9,10);
    }

    return array; 
}

/*int[] Change(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // array[i] = Math.
    }

}
*/

int[] count = CreateArray(4);

//Change(count);



