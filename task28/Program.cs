/*
Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120
*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Wtf(int a)
{
    int result = 1;

    for (int i = 1; i <= a; i++)
    {
        result = result * i;
    }
    return result;
}

int num_result = Wtf(num);

System.Console.WriteLine(num_result);