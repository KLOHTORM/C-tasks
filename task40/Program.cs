/*
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
*/

System.Console.WriteLine("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int userB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число C: ");
int userC = Convert.ToInt32(Console.ReadLine());

bool FindTriagle(int a, int b, int c)
{
    bool result = false;

    if (a + b > c && a + c > b && b + c > a)
    {
        result = true;
    }
    return result;
}

System.Console.WriteLine(FindTriagle(userA, userB, userC));