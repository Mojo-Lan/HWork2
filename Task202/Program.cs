﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.WriteLine("Введите число:");                         //Запрос на ввод числа
// int a = Convert.ToInt32(Console.ReadLine());
// if (a < 100)                                                 //Проверка числа. Кол-во цифр < 3
// {
//     Console.WriteLine("Третьей цифры нет");                  //Вывод что в числе нет трех цифр
// }
// else                                                         //Кол-во цифр >= 3    
// {
//     int b = (int)Math.Floor(Math.Log10(a)) - 2;
//     int d = (int)Math.Pow(10, b);
//     Console.WriteLine(a / d % 10);                           //Вывод искомой цифры
// }



Console.WriteLine("Введите число:");                         //Запрос на ввод числа
int a = Convert.ToInt32(Console.ReadLine());
//int a = 32679;

while (a > 1000) a /= 10;
{
    Console.WriteLine(a % 10);

}


///
/// 
// {
//     Console.WriteLine("Третьей цифры нет");
// }







