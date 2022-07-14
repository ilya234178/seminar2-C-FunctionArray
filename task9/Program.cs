// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int num =new Random().Next(10, 100);
int firstDigit = num / 10;
int secondDigit = num % 10;

Console.WriteLine($"Число:  {num} ");

if(firstDigit == secondDigit)
{
    Console.WriteLine("Цифры равны");
    
}
 else if(firstDigit < secondDigit){
    Console.WriteLine($"Большее: {secondDigit}");
}else{
    Console.WriteLine($"Большее: {firstDigit}");
}
