/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int[] InputArray(int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < arrayLlength; i++)
    {
        array[i] = Prompt($"Введите {i = 1} элемент: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositivNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Lenght; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int lenght = Prompt("Введите колличество чисел: ");
int[] array;
array = InputArray(lenght);
PrintArray(array);
System.Console.WriteLine($"Колличество чисел больше 0 : {CountPositivNumbers(array)}");