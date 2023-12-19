/*
Выполнение через рекурсию (функция вызывает саму себя)

Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

int Massege(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int PowAB(int a, int b)
{
    int count = 0;
    if (b == 1) System.Console.WriteLine($"{a}");
    else if (a == 1) PowAB(a, b = 1);
    else for (int i = 0; i < b; count++)
    {
        int SumA = a * a;
    }
    if (count == b + 1) System.Console.WriteLine($"{a}");
    return count;
}

int userA = Massege("Введите значение A: ");
int userB = Massege("Введите значение B: ");
PowAB(userA, userB);