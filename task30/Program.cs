// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] array = new int[8];
// int rndnum = new Random().Next(0, 2);         //без метода

// for(int i = 0 ; i < array.Length ; i++)
// {
// array [i] = new Random().Next(0 , 2);
// }
// for(int i = 0 ; i < array.Length ; i++)
// {
// if (i == 0) Console.Write("[");
// Console.Write( array[i] + ", " );

// }
// Console.Write("]");


int[] array = GetRandomArray(8);
WriteArrayToConsole(array);

int[] GetRandomArray(int arrayLength )
{
    Random rnd = new Random();
    int[] arr = new int[arrayLength];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void WriteArrayToConsole(int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(",");
    }
    Console.Write("] ");
}