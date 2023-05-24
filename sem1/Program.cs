// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
// camelCase
/*
Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());  //переменная number - целое число, значение - 5

int result = number * number; //если number = 5, то result = 5 * 5 (25)

double resultPartTwo = Math.Pow(number, 2); //number ^ 2


Console.WriteLine("Число " + number + " в квадрате: " + result);
Console.WriteLine("Число " + number + " в квадрате: " + resultPartTwo);*/
/*
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber) //Равно ли 25 числу 5 в квадрате?
{
     //Да, истина
     Console.WriteLine("Число " + firstNumber + " является квадратом числа " + secondNumber);
}
else //Нет
{
      Console.WriteLine("Число " + firstNumber + " НЕ является: " + secondNumber);
}

// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

*/

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1);

while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN = negativeN + 1;
} 