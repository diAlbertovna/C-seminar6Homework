//: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




int GitCount( int number1, int number2, int number3, int number4)
{
    int count = 0;
        if (number1 > 0) count= count +1;
        if (number2 > 0) count= count +1;
        if (number3 > 0) count= count +1;
        if (number4 > 0) count= count +1;
    return count;
}

Console.WriteLine("Enter 4 numbers");
Console.Write("First number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Second number: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Third number: ");
int number3 = int.Parse(Console.ReadLine());
Console.Write("Fourth number: ");
int number4 = int.Parse(Console.ReadLine());
int sum = GitCount( number1, number2, number3, number4);
Console.WriteLine(sum);