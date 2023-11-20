/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10
*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int FindZeroOne(int number)
{
    int result = 0;
    int tmp = 0;

    for (int i = number; i > 0; i/=2)
    {
        tmp = i % 2;
        result = tmp + result * 10;
    }
    return result;
}

System.Console.WriteLine(FindZeroOne(num));