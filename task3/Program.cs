﻿int Read()
{
    Console.Write("Entered number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Table()
{
    int N = Read();
    double s = 0;

    Console.Write($"Cube table for number {N} -> ");
    for (int i=1; i<=N; i++)
    {
        s = Math.Pow(i,3);
        Console.Write($"{s} ");
    }
    
}

Table();