/*
Напишите программу, которая принимает на вход
число (А) и выдаёт сумму чисел от 1 до А.

7 -> 28
4 -> 10
8 -> 36
*/

System.Console.WriteLine("Введите число: ");
int userA =  Convert.ToInt32(Console.ReadLine());


int NumSum(int a)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int user_result = NumSum(userA);

System.Console.WriteLine(user_result);




/*
for (int i = 1; count > 0; count--)
{
    int sum = sum + i;
    System.Console.WriteLine(sum);
}
*/





/*while (count > 0)
{
    int result = count + (count - 1);
    int sum = result + count;
    count = count - 1;

    System.Console.WriteLine(result);
}
*/