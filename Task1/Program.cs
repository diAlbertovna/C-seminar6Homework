// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//y = (k1 * x + b1) - (k2 * x + b2)



Console.Write("Enter b1: ");
double numberB1 = int.Parse(Console.ReadLine());
Console.Write("Enter b2: ");
double numberB2 = int.Parse(Console.ReadLine());
Console.Write("Enter k1: ");
double numberK1 = int.Parse(Console.ReadLine());
Console.Write("Enter k2: ");
double numberK2 = int.Parse(Console.ReadLine());
//GitCount( numberB1, numberB2, numberK1, numberK2);

double x = (- numberB2+ numberB1)/(-numberK1 + numberK2);
double y = numberK2 * x + numberB2;
Console.WriteLine($"b1 = {numberB1}, b2 = {numberB2}, k1 = {numberK1}, k2 = {numberK2} -> coordinats {x};{y}");
