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

int[,] GetRandom2DArray(int first, int last, int row, int column)
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

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

int userArrRow = Massege("Введите кол-во строк: ");
int userArrColumn = Massege("Введите кол-во столбцов: ");
int userArrFirst = Massege("Введите начало диапазона: ");
int userArrayLast = Massege("Введите конец диапазона: ");

int[,] user2DArr = GetRandom2DArray( userArrFirst, userArrayLast, userArrRow, userArrColumn);

Print2DArray(user2DArr);} //зачем то он попросил меня поставить }

//короткий способ с помощью войдов

/*
void Fill2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
}

void Print2DArr(int[,] arr)
{
    for (i = 0; i < GrtLength(0); i++)
    {
        for (j = 0; j < GrtLength(1); j++)
        {
            System.Console.Write($"{arr[i. j]} ")
        }
        System.Console.WriteLine();
    }
}

int[,] user2DArr = new int[3, 4];
Fill2DArr(user2DArr);
Print2DArr(user2DArr);
*/