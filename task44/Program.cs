// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();
int num = GetUserInput();

int GetUserInput()
{
Console.Write("Введите число: ");
return Convert.ToInt32(Console.ReadLine());
}

void Fibonacci(int number)
{
    int f1 = 0;
    int f2 = 1;
    int temp ;
    Console.Write($"{0} {1} ");
    for (int i = 1; i < number -1; i++)
    {
       temp = f1 +f2;
       Console.Write($"{temp} ");
       f1 = f2;
       f2 = temp ;
        
    }
    
    
}

Fibonacci(num);
Console.WriteLine();
