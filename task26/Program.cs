// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// // 89126 -> 5

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int index = 1;                                           //без метода
// int x = 0;
// while(index <= number)
// {
//     x = x + 1;
//     index = index * 10;
// }
// Console.WriteLine($"Колличество цифр в числе: {x}");
int GetNum(int numb)
{
    int index = 1;                                           //через метод
    int x = 0;
    while (index <= numb)
    {
        x = x + 1;
        index = index * 10;
    }
    return x;
}
int res = GetNum(number);
Console.WriteLine($"Колличество цифр в числе: {res}");