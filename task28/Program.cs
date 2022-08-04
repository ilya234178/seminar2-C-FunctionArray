// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 1;
    for (int i = 1; i <= number; i++)               //через метод
    {
        sum = sum * i;
    }
    return sum;
}
int result = GetSum(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");