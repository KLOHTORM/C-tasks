/*
Задайте двумерный массив. Напишите программу, которая поменяет 
местами первую и последнюю строку массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
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

int[,] ChangeRow(int[,] arr)
{
    int[,] array = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0) array[0, j] = arr[arr.GetLength(0) - 1, j];
            else
            {
                if(i == (arr.GetLength(0) - 1))
                {
                    array[arr.GetLength(0) - 1, j] = arr[0, j];
                }
                else array[i, j] = arr[i, j];
            }
        }
    }
    return array;
}

int userRow = Massege("Введите кол-во строк: ");
int userColumn = Massege("Введите кол-во столбцов: ");
int userFirst = Massege("Введите начало диапазона: ");
int userLast = Massege("Введите конец диапазона: ");
int[,] user2DArr = Get2DArr(userFirst, userLast, userRow, userColumn);

Print2DArr(user2DArr);
System.Console.WriteLine();

System.Console.WriteLine("Новый массив: ");
int[,] newArr = ChangeRow(user2DArr);

Print2DArr(newArr);
System.Console.WriteLine();