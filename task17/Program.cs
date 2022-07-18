// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

                                                                 
Console.WriteLine("Введите координаты точки");

Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
                                                //обычное решение
// if(x > 0 && y > 0)
// {
//     Console.WriteLine("Четверты первая");
// }
// else if(x < 0 && y > 0)
// {
//     Console.WriteLine("Четверты вторая");
// }
// else if(x < 0 && y < 0)
// {
//     Console.WriteLine("Четверть третья");
// }
// else if(x > 0 && y < 0)
// {
//     Console.WriteLine("Четверть четвертая");
// }else {
//     Console.WriteLine("Введены некоректные координаты");
// }

string Quarter(int xc ,int yc)  //решение методом(функцией)
{
  if(xc > 0 && yc > 0)return  "Четверть первая";
  if(xc < 0 && yc > 0)return "Четверты вторая";
  if(xc < 0 && yc < 0)return "Четверть третья";
  if(xc > 0 && yc < 0)return "Четверть четвертая";
  return "Введены некоректные координаты";
}

string result = Quarter( x, y);
Console.WriteLine(result);