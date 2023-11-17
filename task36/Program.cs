/*
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Аргументы, передаваемые в метод/функцию:
'18, 76, 11'

На выходе:
18      76      11  
Сумма нечетных элементов: 76
*/

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
            System.Console.Write("    ");
        }
    }
}

int FindNum(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        sum++;    }
    return sum;
}


int[] userArray = GetRandomArray(10);
PrintArray(userArray);

System.Console.WriteLine();

System.Console.WriteLine($"Количество нечетных элементов: {FindNum(userArray)}");