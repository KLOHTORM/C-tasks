/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


int[] Febonachi(int number)
{
    int size = 0;
    if (number < 2) size = 2;
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length)
        {
            System.Console.Write(", ");
        }
    }

}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintArray(Febonachi(num));