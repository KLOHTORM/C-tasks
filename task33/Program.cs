/*
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length)
        {
            System.Console.Write(", ");
        }
    }

}

bool FindNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i])
        return true;
    }
    return false;
}

System.Console.WriteLine("Диапазон массива от: ");
int userFirst = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Диапазон массива до: ");
int userLast = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(userFirst, userLast, userSize);
PrintArray (userArray);

System.Console.WriteLine();

System.Console.WriteLine("Случайное число для нахождения в массиве: ");
int userNum = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(FindNum(userArray, userNum));
