// Задача 13 (Task1): Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: "); 
string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.Write($"{number} -> {numberArray[2]}");
}
else
{
    Console.Write($"{number} -> Tретьей цифры нет");
}