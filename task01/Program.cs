/*
1. Напишите программу, которая на вход принимает 2 числа и проверяет, является ли 1 число квадратом 2
*/

System.Console.WriteLine("Введите 1 число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите 2 число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int sqNumber1 = userNumber2 * userNumber2;

bool result = userNumber1 == sqNumber1;

System.Console.WriteLine(result);