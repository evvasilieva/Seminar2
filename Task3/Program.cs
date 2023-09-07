// Задача 15 (Task 3): Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: "); 
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7)
{
    Console.WriteLine("{0} -> Да, этот день - выходной", dayWeek);
}
else if (dayWeek >= 1 && dayWeek <= 5)
{
    Console.WriteLine("{0} -> Нет, этот день не является выходным", dayWeek);
}
else
{
    Console.WriteLine("{0} -> дня недели с такой цифрой нет", dayWeek);
}
