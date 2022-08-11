// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



Console.Clear();

void Reverse(int[] arr)
{
    int size = arr.Length;
    int index1 = 0;
    int index2 = size - 1;

    while (index1 < index2)
    {
       int temp = arr[index1];
       arr[index1] = arr[index2];
        arr[index2] = temp;

        index1++;
        index2--;
    }
}

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
int[] array = CreateArrayRndInd(5, 6, 15);
PrintArray(array);
Reverse(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();