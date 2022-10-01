/*Задача 4: Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число:");
string Number1 = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string Number2 = Console.ReadLine();
Console.WriteLine("Введите третье число:");
string Number3 = Console.ReadLine();

int Num1 = int.Parse(Number1);
int Num2 = int.Parse(Number2);
int Num3 = int.Parse(Number3);

int max = Num1;

if (Num2 > max)
{
    max = Num2;
}
if (Num3 > max)
{
    max = Num3;
}

Console.WriteLine($"Максимальное число равно {max}");

