/*
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз 
встречается элемент входных данных.

{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
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

void PrintNumCount(int[,] arr, int num)
{
    for (int a = 0; a < num + 1; a++)
    {
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (a == arr[i, j]) count++;
            }
        }
        System.Console.WriteLine($"Число {a} встречается {count} раз.");
    }
}



int userRow = Massege("Введите кол-во строк: ");
int userColumn = Massege("Введите кол-во столбцов: ");
int userFirst = Massege("Введите начало диапазона: ");
int userLast = Massege("Введите конец диапазона: ");
int[,] user2DArr = Get2DArr(userFirst, userLast, userRow, userColumn);

Print2DArr(user2DArr);
System.Console.WriteLine();

PrintNumCount(user2DArr, userLast);