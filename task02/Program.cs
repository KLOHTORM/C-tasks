/*
Написать программу, которая на входе принимает 2 числа и показвает какое число больше, а какое меньше
*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    System.Console.WriteLine($"{number1} большее число, {number2} меньшее число");
}
else
    if (number2 > number1)
    {
    System.Console.WriteLine($"{number2} большее число, {number1} меньшее число");
    }