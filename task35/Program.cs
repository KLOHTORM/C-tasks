﻿/*
Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении 
сделайте для 123

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] GetRandomArray(int first, int last, int size)
{
    int[] array = new int[123];
    for (int i = 0; i < 123; i++)
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

int FindArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
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

System.Console.WriteLine($"{FindArray(userArray)}");