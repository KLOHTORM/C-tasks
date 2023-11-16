/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);

        if (i < arr.Length - 1) System.Console.WriteLine(", ");
    }
}

int ProductArray(int[] arr)
{
    int[] result = new int[arr.Length / 2];
    int sum = 0;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        sum = arr[i] * arr[arr.Length - 1 - i];
        result[i] = sum;
    }

    return result;
}

int[] userArray = GetRandomArray(6);
PrintArray (userArray);

System.Console.WriteLine();

int[] newArray = ProductArray(userArray);
PrintArray(newArray);