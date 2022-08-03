// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// // 8 -> 36

Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for(int i = 1; i <= n ; i++)            //без метода
// {
//  sum = sum + i;
// }

// Console.WriteLine($"сумма чисел от 1 до {n} = {sum}");

int GetSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)               //через метод
    {
        sum = sum + i;
    }
    return sum;
}
int result = GetSum(n);
Console.WriteLine($"сумма чисел от 1 до {n} = {result}");