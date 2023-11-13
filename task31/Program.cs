/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/











int[] GetRandomArray(int first, int last, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(first, last);
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

int SumPositiv(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result += array[i];
    }
    return result;
}

int SumNegative(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) result += array[i];
    }
    return result;
}

System.Console.WriteLine("Диапазон массива от: ");
int userFirst = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Диапазон массива до: ");
int userLast = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(userFirst, userLast, userSize);
PrintArray (userArray);

int posArraySum = SumPositiv(userArray);
int negArraySum = SumNegative(userArray);

System.Console.WriteLine($"Сумма положительных чисел {posArraySum}, сумма отрицательных чисел {negArraySum}");