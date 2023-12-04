/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] GetRandom2DArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
}

int SumIndex(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i,i];
    }
    return sum;
}

System.Console.WriteLine("Введите кол-во строк: ");
int userArrRow = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите кол-во столбцов: ");
int userArrColumn = Convert.ToInt32(Console.ReadLine());

int[,] user2DArr = GetRandom2DArray(userArrRow, userArrColumn);

System.Console.WriteLine();

Print2DArray(user2DArr);

int userSum = SumIndex(user2DArr);

System.Console.WriteLine();

System.Console.WriteLine(userSum);
