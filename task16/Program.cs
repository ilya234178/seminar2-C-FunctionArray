// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
bool IsPow(int a, int b)
{
    return a * a == b;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (IsPow(num1, num2))
    Console.WriteLine($"{num1},{num2} -> да");
else if (IsPow(num2, num1))
    Console.WriteLine($"{num1},{num2} -> да");
else
{
    Console.WriteLine($"{num1},{num2} -> нет");
}

