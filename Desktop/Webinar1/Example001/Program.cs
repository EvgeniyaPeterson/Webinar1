﻿// Напишите программу, которая на вход принимает (целое) число
// и выдает (на консоль) его квадрат
//(число умноженное на само себя)

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
Console.WriteLine("Программа вычисления квадрата числа");
Console.WriteLine("Введите число");
// 1. Ввод числа
int input = int.Parse(Console.ReadLine()!);
// 2. Вычисление квадрата числа
int result = input*input;
// 3. Вывод результата на консоль
Console.WriteLine("Квадрат числа = " + result);

int i=0;
Console.WriteLine("i = " + i);
i+=2;
Console.WriteLine("i = " + i);
i+=4;
Console.WriteLine("i = " + i);