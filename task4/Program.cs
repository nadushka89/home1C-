/* Напишите программу,которая на вход принимает одно число (N), а на 
выходе показывает все целые  в промеж от -N до N
4-> "-4,-3,-2,-1, 0,1,2,3,4"
2-> "-2,-1,0,1,2"
*/
Console.WriteLine("Введите число N");
string numbN = Console.ReadLine();
int numb = int.Parse(numbN);

for (int i = -numb; i <= numb; i++)
{
    Console.Write($" {i} ");

}
