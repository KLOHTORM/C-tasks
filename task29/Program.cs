/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int count = 0;

while (count < 8)
{
    int num = new Random().Next(1, 100);
    System.Console.Write(num);

    if (count < 7)
    {
        System.Console.Write(", ");
    }

    count++;
}
