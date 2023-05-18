﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84;  // A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

int squareX = (x2-x1)*(x2-x1);
int squareY = (y2-y1)*(y2-y1);
int squareZ = (z2-z1)*(z2-z1);

double lenth = Math.Sqrt(squareX+squareY+squareZ);
lenth = Math.Round(lenth, 2);
Console.WriteLine(lenth);
