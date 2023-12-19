/*
Выполнение через рекурсию (функция вызывает саму себя)

Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

int Massege(string massage)
{
    System.Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void IntNum(int num, int a = 1)
{
    if (num >= a)
    {
        System.Console.Write($"{a}");
        IntNum(num, a + 1);
    }
    else if (num == 1)
    {
        System.Console.Write($"{num}");
        return;
    }
}

int UserNum = Massege("Введите значение N: ");
IntNum(UserNum);