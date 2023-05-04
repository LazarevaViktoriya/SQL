using System;
class HelloWorld {
static void Main() {
Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Абсолютное значение"+Math.Abs(b));
Console.WriteLine("ВВЕДИТЕ ЗНАЧЕНИЕ a");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное значение",Math.Max(a,b));
double x= Convert.ToDouble(Math.Round(Math.Sqrt(a), 2));
Console.WriteLine ("Извлеченный корень равен"+ x);

}
}