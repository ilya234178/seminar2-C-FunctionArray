// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.Clear();
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);

        }
    }
    return matrix;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}
void SecondMartix(int[,] array )
{   
  for (int i = 0; i < array.GetLength(1); i++)
  {
    int temp = array[0,i];
    array[0,i] = array[array.GetLength(0)-1 ,i];
    array[array.GetLength(0)-1 ,i] = temp;
  }
}
int[,] matrixResult = GetMatrix(4,4);
PrintMatrix(matrixResult);
Console.WriteLine();
SecondMartix(matrixResult);
PrintMatrix(matrixResult);