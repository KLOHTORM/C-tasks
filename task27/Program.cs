/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Sum(int a)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

int result = Sum(num);
System.Console.WriteLine(result);