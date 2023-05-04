using System;

class Program {
static void Main() {
Console.WriteLine("Введите значение x в радианах:");
double x = Convert.ToDouble(Console.ReadLine());

double g = x * 180 / Math.PI; // Формула для перевода из радианов в градусы

Console.WriteLine("Значение x в градусах: " + g);
}
}