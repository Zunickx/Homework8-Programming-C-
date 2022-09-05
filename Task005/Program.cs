﻿// Напишите программу, которая заполнит спирально массив 4 на 4

using System;

void PrintArray(int[,] array)
{
    Console.WriteLine("Спиральный массив: ");
    for(var i = 0; i < array.GetLength(0); i++)
    {
        for(var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int n = 4, m = 4;
var a = SnakeArray(n, m);

PrintArray(a);

int[,] SnakeArray(int n, int m)
{
    var arr = CreateSnake(n, m);
    for(var i = 0; i < m; i++)
    {
        for(var j = 0; j < n / 2; j++)
        {
            (arr[i, j], arr[i, m - j - 1]) = (arr[i, m - j - 1], arr[i, j]);
        }
    }

    arr = Rotate(arr);
    arr = Rotate(arr);
    arr = Rotate(arr);

    return arr;
}

int[,] Rotate(int[,] m)
{
    var result = new int[m.GetLength(1), m.GetLength(0)];

    for(var i = 0; i < m.GetLength(1); i++)
    {
        for(var j = 0; j < m.GetLength(0); j++)
        {
            result[i, j] = m[m.GetLength(0) - j - 1, i];
        }
    }
    return result;
}

int[,] CreateSnake(int n, int m)
{
    var array = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for(var i = 0; i < array.Length; i++)
    {
        array[col, row] = i + 1;
        if(--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) -2;
            var temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return array;
}