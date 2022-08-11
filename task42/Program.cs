using System.Text;
{

}
// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int num = GetUserInput();

Console.Write(ConvertToBinary(num));
Console.WriteLine();

string ConvertToBinary(int num)
{
    string binary = string.Empty;

    while (num >= 1)
    {
        binary += num % 2;
        num /= 2;
    }
    var item = binary.Reverse();
    binary = "";
    foreach (var i in item)
    {
        binary += i.ToString();
    }
    return binary;
}
string WriteArrayAsString(int[] array)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < array.Length; i++)
    {
        sb.Append(array[i]);
    }
    return sb.ToString();
}
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

int GetUserInput()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}