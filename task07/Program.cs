/*
Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа
*/

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int third = userNumber % 10;

System.Console.WriteLine(third);