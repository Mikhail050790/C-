// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


int num1 = new Random().Next(2, 76);
int num2 = new Random().Next(2, 76);
Console.WriteLine($"Число1 {num1}, число2 {num2}");

if(num2==num1*num1)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}