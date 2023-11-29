/*
38. Напишите программу для работы с массивом вещественных чисел.
Аргументы, передаваемые в метод/функцию:
'3.17, 8.94, 2.36, 5.72, 0.85'
На выходе:

Массив:
3.17    8.94    2.36    5.72    0.85    
Разность между максимальным и минимальным элементом = 8.09
*/

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
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

int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i]) max = arr[i];
    }
    return max;
}

int FindMin(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i]) min = arr[i];
    }
    return min;
}

int DifMaxMin(int[] arr)
{
    int result = FindMax(arr) - FindMin(arr);
    return result;
}

System.Console.WriteLine();

int[] userArray = GetRandomArray(5);
PrintArray(userArray);

System.Console.WriteLine();

System.Console.WriteLine();

System.Console.WriteLine($"Разница между максимальным элементом({FindMax(userArray)}) и минимальным элементом({FindMin(userArray)}) будет {DifMaxMin(userArray)}");

System.Console.WriteLine();