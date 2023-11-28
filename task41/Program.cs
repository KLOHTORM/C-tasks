/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

int Count(int[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        size++;
    }
    return size;
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

System.Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] userArr = GetArray(size);
PrintArray(userArr);

System.Console.WriteLine();
System.Console.WriteLine($"{Count(userArr)}");