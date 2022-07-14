// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int num = new Random().Next(10, 100);
// int firstDigit = num / 10;
// int secondDigit = num % 10;

// Console.WriteLine($"Число:  {num} ");

// if(firstDigit == secondDigit)
// {
//     Console.WriteLine("Цифры равны");
    
// }
//  else if(firstDigit < secondDigit){
//     Console.WriteLine($"Большее: {secondDigit}");
// }else{
//     Console.WriteLine($"Большее: {firstDigit}");
// }



int MaxDigit(int number)
{
int firstDigit = number / 10;
int secondDigit = number % 10;
if(firstDigit == secondDigit)return  -1;
if(firstDigit < secondDigit)return secondDigit;
return firstDigit;
 
}


int maxDigit = MaxDigit(num);
Console.WriteLine($"Число:  {num} ");
if(maxDigit == 0) Console.WriteLine($"{num} Цифры одинаковые");
else Console.WriteLine($"Большее:{maxDigit}");
