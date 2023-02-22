﻿namespace BasiccorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a value for N as a command-line argument.");
                return;
            }

            int n = Convert.ToInt32(args[0]);

            if (n < 0 || n >= 31)
            {
                Console.WriteLine("N must be between 0 and 30.");
                return;
            }

            Console.WriteLine("Powers of 2 less than or equal to 2^" + n + ":");

            int power = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("2^" + i + " = " + power);
                power *= 2;
            }
        }
    }
}
        
        
