/*
Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент массива.

Например, задан массив:
-1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 2 3
4 2 4
2 6 7
*/

int Massege(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[,] Get2DArr(int first, int last, int row, int column)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(first, last+1);
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

(int row, int column) FindMin(int[,] arr)
{
    int min = arr[0, 0];
    int minColumn = 0;
    int minRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (min > arr[i, j])
            {
                min = arr[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DelRC(int[,] arr, int row, int column)
{
    int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int a = 0;
    int b = 0;
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        if (i < row)
        { a = i; }
        else
        { a = i + 1; }

        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            if (j < column) { b = j; }
            else { b = j + 1; }
            newArr[i, j] = arr[a, b];
        }
    }
    return newArr;
}

int userRow = Massege("Введите кол-во строк: ");
int userColumn = Massege("Введите кол-во столбцов: ");
int userFirst = Massege("Введите начало диапазона: ");
int userLast = Massege("Введите конец диапазона: ");
int[,] user2DArr = Get2DArr(userFirst, userLast, userRow, userColumn);

Print2DArr(user2DArr);
System.Console.WriteLine();

(int row, int column) = FindMin(user2DArr);

System.Console.WriteLine("Измененный массив:");
Print2DArr(DelRC(user2DArr, row, column));