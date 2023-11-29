/*
Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.
*/

int[] GetNewArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
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
            System.Console.Write("  ");
        }
    }
}

int[] CloneArray(int[] arr)
{
    int size = arr.Length;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

Console.Clear();

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = GetNewArray(size);
PrintArray(arr);

System.Console.WriteLine();

int[] array = CloneArray(arr);
PrintArray(array);