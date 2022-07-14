// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100, 1000);

//     int firstDigit = num / 100; 
//     int thirdDigit = num % 10;
//     int res = firstDigit * 10 + thirdDigit; 
   
//  Console.WriteLine($"{num} = {res}");
                                    //    решение через метод
int num = new Random().Next(100, 1000);

int result = RemoveSecond(num);

Console.WriteLine($"{num} -> {result}");

int RemoveSecond(int num)
{
    int firstDigit = num / 100; 
    int thirdDigit = num % 10;
    return firstDigit * 10 + thirdDigit;
}