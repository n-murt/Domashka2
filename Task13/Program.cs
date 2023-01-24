// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
string str = n.ToString();
if (str.Length > 2)
{
    Console.WriteLine($"Третья цифра - {str[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}