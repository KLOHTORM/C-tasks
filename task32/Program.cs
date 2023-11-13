/*
Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] GetRandomArray(int first, int last, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(first, last + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }
    }

    System.Console.Write("] ->[");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
        System.Console.Write(array[i]);
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

System.Console.WriteLine("Диапазон массива от: ");
int userFirst = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Диапазон массива до: ");
int userLast = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(userFirst, userLast, userSize);
PrintArray(userArray);

