// напишите программу, которая будет выдавать названия дня недели по заданному номер
// 3->среда, 5->пятница

Console.WriteLine("Введите число от 1 до 7");
string dayOfTheWeek = Console.ReadLine();

if (dayOfTheWeek == "1")
{
    Console.WriteLine($"{dayOfTheWeek} -> понедельник");
}
else if (dayOfTheWeek == "2")
{
    Console.WriteLine($"{dayOfTheWeek} -> вторник");
}
else if (dayOfTheWeek == "3")
{
    Console.WriteLine($"{dayOfTheWeek} -> среда");
}
else if (dayOfTheWeek == "4")
{
    Console.WriteLine($"{dayOfTheWeek} -> четверг");
}
else if (dayOfTheWeek == "5")
{
    Console.WriteLine($"{dayOfTheWeek} -> пятница");
}
else if (dayOfTheWeek == "6")
{
    Console.WriteLine($"{dayOfTheWeek} -> суббота");
}
else if (dayOfTheWeek == "7")
{
    Console.WriteLine($"{dayOfTheWeek} -> воскресение");
}
else
{
    Console.WriteLine("Ошибка! Вы ввели неверный день недели");
}