// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] CreateArrayRndInd(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}
int[] CopyArray(int[] array)
{
    int[] copyArr = new int[array.Length];

    for (int i = 0; i < copyArr.Length; i++)
    {
        copyArr[i] = array[i];
    }
    return copyArr;
}

int[] array = CreateArrayRndInd(5, 1, 15);
int[] copyArr = CopyArray(array);
Console.Write("Исходный массив: " );
 PrintArray(array);
 Console.WriteLine();
Console.Write("Копия массива: ");
PrintArray(copyArr);
Console.WriteLine();
array[0] = 3;
Console.Write("Исходный массив с изменениями: ");
PrintArray(array);
Console.WriteLine();
Console.Write($"Копия массива: " );
PrintArray(copyArr);
Console.WriteLine();