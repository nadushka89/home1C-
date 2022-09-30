// Напишите программу,которая на вход применяет число и выдает его квадрат 
//(число умноженное на само себя)

Console.WriteLine("Введите число:");
string numberStr = Console.ReadLine();

// Получаем числовое значение из строкового
int number = int.Parse(numberStr); // int number = Convert.ToInt32 (numberStr)

int result=number*number;

Console.WriteLine($"{number}->{result}");


