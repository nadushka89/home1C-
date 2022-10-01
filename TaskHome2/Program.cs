/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее,  а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите число a:");
string FirstNumber=Console.ReadLine();
Console.WriteLine("Введите число b");
string SecondNumber=Console.ReadLine();

int FirstNum=int.Parse(FirstNumber);
int SecondNum=int.Parse(SecondNumber);

if (FirstNum>SecondNum)
{
    Console.WriteLine($"max = {FirstNum}");
}
else
{
     Console.WriteLine($"max = {SecondNum}");
}