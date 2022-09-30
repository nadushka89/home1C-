// напишите программу,которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго
// a=25, b=5 ->да
// a=2, b=10 ->нет

Console.WriteLine("Введите число a:");
string FirstNumber = Console.ReadLine();
Console.WriteLine("Введите число b:");
string SecondNumber = Console.ReadLine();

int FirstNum = int.Parse(FirstNumber);
int SecondNum = int.Parse(SecondNumber);

if (SecondNum * SecondNum == FirstNum)
{
    Console.WriteLine($"Число{FirstNum} является квадратом {SecondNum}");
}
else
{
    Console.WriteLine($"Число{FirstNum} не является квадратом {SecondNum}");
}
