﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

int Prompt(string message)// в скобки передадим сообщение, когда будем вызывать метод Prompt
{
    Console.WriteLine(message);// Печать сообщения, которое введём при вызове метода
    int num = int.Parse(Console.ReadLine()!);// объявляем переменную num и присваиваем ей значение, которое введёт пользователь и конвертируем в число
    return num;// возвращаем значение num, чтобы дальше с ним работать
}

void GetResult(int X, int Y)
{ 
if (X > 0 && Y > 0)
{
    Console.WriteLine("I четверть");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("II четверть");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("III четверть");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("IV четверть");
}
else
{
    Console.WriteLine("Центр одной из осей");
}
}
int x = Prompt("Введите точку Y: ");// Объявляем x и запускаем метод, добавляя в него наже послание, вместо message
int y = Prompt("Введите точку Y: ");// Объявляем y и запускаем метод, добавляя в него наже послание, вместо message
GetResult(x, y);
