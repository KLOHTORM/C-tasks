/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 1000 ==0)
{
   int number1 = number % 10;
   System.Console.WriteLine(number1);
}
else
{
    System.Console.WriteLine("третьей цифры нет");
}