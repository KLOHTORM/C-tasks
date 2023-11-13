/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetArray(int first, int last, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(first, last + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length)
        {
            System.Console.Write(", ");
        }
    }

}

System.Console.WriteLine("Диапазон массива от: ");
int userFirst = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Диапазон массива до: ");
int userLast = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userFirst, userLast, userSize);
PrintArray(userArray);