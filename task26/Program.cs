// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// // 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 1;
int x = 0;
while(index <= number)
{
    x = x + 1;
    index = index * 10;
}
Console.WriteLine($"Колличество цифр в числе: {x}");