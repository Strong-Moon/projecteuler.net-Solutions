using System;

namespace ProjectEuler
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            const long expected_number = 600851475143;
            long num = expected_number;
            long LF  = 0;

            int counter = 2;
            while (counter * counter <= num)
            {
                if (num % counter == 0)
                {
                    num = num / counter;
                    LF = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (num > LF )
            { 
                LF  = num;
            }
            System.Console.WriteLine($"The largest prime factor of the number {expected_number} is {LF}");
        }
    }
}
