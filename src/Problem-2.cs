using System;

namespace ProjectEuler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num1 = 1;
            long num2 = 1;
            long result = 0;
            long sum = 0;

            while (result < 4000000)
            {
                if ((result % 2) == 0)
                {
                    sum += result;
                }

                result = num1 + num2;
                num2 = num1;
                num1 = result;
            }
            System.Console.WriteLine($"The sum of the even-values is {sum}");
        }
    }
}
