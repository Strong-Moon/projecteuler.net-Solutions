﻿using System;

namespace ProjectEuler
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (((i % 3) == 0) || ((i % 5) == 0))
                {
                    sum += i;
                } 
            }
            System.Console.WriteLine($"The sum of all the multiples of 3 or 5 below 1000 is {sum}.",sum);
        }
    }
}
// The answer is 233168