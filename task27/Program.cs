/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = num / 100;
int b = num / 10;
int c = b % 10;
int d = num % 10;

int result = a + c + d;

System.Console.WriteLine(result);