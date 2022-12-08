// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int a;
Console.Write($"Введите число: ");
string number = Console.ReadLine()!;

int.TryParse(number, out a);

if (a > 99)
{
    Console.Write($"Третья цифра = {number[2]}\n");
}
else
{
    Console.Write($"В числе нет третьей цифры\n");
}