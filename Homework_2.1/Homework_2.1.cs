﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число число: ");
int userNumberA = int.Parse(Console.ReadLine() ?? "");

int a1 = userNumberA % 100 / 10;

Console.WriteLine($"получаем вот такое число -> {a1}.");