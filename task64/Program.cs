/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int Massege(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void FromN(int num)
{
    if (num > 1)
    {
        System.Console.Write($"{num} ");
        FromN(num - 1);
    }
    else if (num == 1)
    {
        System.Console.Write($"{num}");
        return;
    }
}

int userN = Massege("Введите значение N: ");
FromN(userN);