/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
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

int userRow = Massege("Введите кол-во строк: ");
int userColumn = Massege("Введите кол-во столбцов: ");
int userFirst = Massege("Введите начало диапазона: ");
int userLast = Massege("Введите конец диапазона: ");
int[,] user2DArr = Get2DArr(userFirst, userLast, userRow, userColumn);


Print2DArr(user2DArr);