// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int x = 1;
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
while (x <= number)
{
    if (x % 2 == 0)
    {
        Console.WriteLine(x);
    }
    x++;
}