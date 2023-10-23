/*
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
*/

System.Console.WriteLine("Введите ночер четверти: ");
int userCvoter = Convert.ToInt32(Console.ReadLine());

if (userCvoter == 1)
{
    System.Console.WriteLine("Значения X и Y будут больше 0");
}

if (userCvoter == 2)
{
    System.Console.WriteLine("Значения X будут меньше 0, а Y больше 0");
}

if (userCvoter == 3)
{
    System.Console.WriteLine("Значения X и Y будут меньше 0");
}

if (userCvoter == 4)
{
    System.Console.WriteLine("Значения X будут больше 0, а Y меньше 0");
}

if (userCvoter > 4)
{
    System.Console.WriteLine("В четверти 4 цифры, не больше");
}
