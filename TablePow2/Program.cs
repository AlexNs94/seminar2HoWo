﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//т 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4



Console.Clear();

void TablePow2(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count <= number)
    {
        int pow = count*count;
        Console.Write(pow + " ");
        count ++;
    }
    Console.WriteLine();
}

TablePow2("Введите число N : ");