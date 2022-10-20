// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите число");
int numX1= int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numY1= int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numX2= int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int numY2= int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(numX1-numX2,2)+Math.Pow(numY1-numY2,2));
Console.WriteLine(d);