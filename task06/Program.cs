/*
Внутри класса Answer напишите метод CheckIfEven, который принимает число number и выводит, является ли число четным (делится ли оно на 2)

number = 4 -> число 4 четное
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine($"Число {number} четное");
}
else
{
    System.Console.WriteLine($"Число {number} нечетное");
}
