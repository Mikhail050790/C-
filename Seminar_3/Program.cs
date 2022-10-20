// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число");
int numX= int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numY= int.Parse(Console.ReadLine());

if(numX>0&&numY>0)
{
    Console.WriteLine("1");
}
if(numX>0&&numY<0)
{
    Console.WriteLine("4");
}
if(numX<0&&numY>0)
{
    Console.WriteLine("2");
}
if(numX<0&&numY<0)
{
    Console.WriteLine("3");
}
