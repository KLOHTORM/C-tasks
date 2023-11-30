/*
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/

int Massege(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] GetRandom2DArray(int first, int last, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(first, last+1);
        }
    }
    return array;
}

void Print2DArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length)
        {
            System.Console.Write(", ");
        }
    }

int userArrX = Massege("Введите кол-во строк: ");
int userArrY = Massege("Введите кол-во столбцов: ");
int userArrFirst = Massege("Введите начало диапазона: ");
int userArrayLast = Massege("Введите конец диапазона: ");