/*
Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
Аргументы, передаваемые в метод/функцию:
'124, 378, 593, 821, 456'

Массив:
124     378     593     821     456 
Количество четных элементов: 3
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
            System.Console.Write(", ");
        }
    }

}

int FindNum(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        sum++;    }
    return sum;
}


int[] userArray = GetRandomArray(10);
PrintArray(userArray);

System.Console.WriteLine();

System.Console.WriteLine($"Количество четных элементов: {FindNum(userArray)}");