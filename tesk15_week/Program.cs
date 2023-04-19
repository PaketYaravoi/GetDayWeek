/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.Write("Введите число дня недели: ");
string input = Console.ReadLine()!;
int number = int.Parse(input);
Console.WriteLine(number);

if(number > 7 || number < 1)
{
    Console.WriteLine("Недопустимое значение");
    
}
else
{
    if(number == 6 || number == 7)
    {
        Console.WriteLine("Да!");
    }
    else
    {
        Console.WriteLine("Нет!");
    }
}
