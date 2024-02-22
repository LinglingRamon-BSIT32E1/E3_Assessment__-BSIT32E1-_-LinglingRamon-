using System;

    class Loop
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                double square = Math.Sqrt(i);
                Console.WriteLine("The square root of " + i + " is " + square);
            }
        }
    }