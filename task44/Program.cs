/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


int[] Febonachi(int number)
{
    int[] arr = new int[number];
    arr[0] = 0;
    arr[1] = 1;
    if (number > 2)
    {
        for (int i = 2; i < number; i++)
        {
            arr[i] = arr[i-1] + arr[i-2];
        }
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length)
        {
            System.Console.Write("  ");
        }
    }

}

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

PrintArray(Febonachi(num));