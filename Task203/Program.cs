﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6, 7 - выходной.
// НО дня с индексом 0 или 12 не существует.
// 6 -> да
// 7 -> да
// 1 -> нет 


Console.WriteLine("Введите число дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

void Week(int number)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Выходной день");
    }

    else if (number < 1 || number > 7)
    {

        Console.WriteLine("Вы ввели неверное число!");
    }
    else
        Console.WriteLine("Рабочий день");
}
Week(number);


