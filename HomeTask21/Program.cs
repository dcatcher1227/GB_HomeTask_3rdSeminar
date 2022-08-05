// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int[] pointA = new int[3];
int[] pointB = new int[3];

Console.WriteLine(" Enter 1st A coordinate: ");
pointA[0] = int.Parse(Console.ReadLine());

Console.WriteLine(" Enter 2nd A coordinate: ");
pointA[1] = int.Parse(Console.ReadLine());

Console.WriteLine(" Enter 3rd A coordinate: ");
pointA[2] = int.Parse(Console.ReadLine());

Console.WriteLine(" Enter 1st B coordinate: ");
pointB[0] = int.Parse(Console.ReadLine());

Console.WriteLine(" Enter 2nd B coordinate: ");
pointB[1] = int.Parse(Console.ReadLine());

Console.WriteLine(" Enter 3rd B coordinate: ");
pointB[2] = int.Parse(Console.ReadLine());

int a = pointA[0] - pointB[0];
int b = pointA[1] - pointB[1];
int c = pointA[2] - pointB[2];

double result = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine(Math.Round (result, 2));
