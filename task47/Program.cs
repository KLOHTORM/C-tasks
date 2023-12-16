/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

int Massege (string massege)
{
    System.Console.Write(massege);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] New2DArr(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(m, n+1);
        }
    }
    return array;
}

void Print2DArr (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
    }
}

Console.Clear();

int numM = Massege("Введите кол-во строк: ");
int numN = Massege("Введите кол-во столбцов: ");
int[,] matrix = New2DArr(numM, numN);
Print2DArr(matrix);