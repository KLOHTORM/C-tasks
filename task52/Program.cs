/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
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

double[] ColumnSum(int [,] arr)
{
    double[] array = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        array[i] = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            array[i] += arr[j, i];
        }
        array[i] =  Math.Round(array[i]/arr.GetLength(0),2,MidpointRounding.AwayFromZero);
    }
    return array;
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (position == (count - 1))
        {
            Console.Write($"{col[position]:0.00}");
            position++;
        }
        else
        {
            Console.Write($"{col[position]:0.00}; ");
            position++;
        }
    }
}

int userRow = Massege("Введите кол-во строк: ");
int userColumn = Massege("Введите кол-во столбцов: ");
int userFirst = Massege("Введите начало диапазона: ");
int userLast = Massege("Введите конец диапазона: ");
int[,] user2DArr = Get2DArr(userFirst, userLast, userRow, userColumn);

Print2DArr(user2DArr);
System.Console.WriteLine();

System.Console.WriteLine("Среднее арифметическое каждого столбца: ");
double[] array = ColumnSum(user2DArr);
PrintArray(array);

System.Console.WriteLine();