/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(число читается слева направо и справа на лево).

Метод должен проверить является ли число пятизначным, в противном случае - вывести "Число не пятизначное" и False в следующей строке.
Для остальных чисел вернуть True или False.

14212 -> False
12821 -> True
234322 -> Число не пятизначное False
*/

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int n1 = num / 10000;
int n2 = num / 1000 % 10;
int n3 = num / 100 % 10;
int n4 = num % 100 / 10;
int n5 = num % 10;

if (num / 100000 ==0 & num >= 10000)
{
    if (n1 == n5 & n2 == n4)
    {
        System.Console.WriteLine("True");
    }
    else System.Console.WriteLine("False");
}
else System.Console.WriteLine("Число не пятизначное False");