﻿// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int num = new Random().Next(10, 1000);
int num1 = (num / 100)*10+num%10;

Console.WriteLine(num);

Console.WriteLine(num1);
