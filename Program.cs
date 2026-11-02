using System;

for (int i = 1; i <= 5; i++)
{
    for (int j = 0; j < 6 - i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        if (j > 1) Console.Write(" ");
        Console.Write("*");
    }

    Console.WriteLine();
}
