﻿namespace FindMaxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindMax findMax = new FindMax();

            int result = findMax.FindMaxInteger(380, 320, 5);

            Console.WriteLine("Greatest number among three numbers is : " + result);

            Console.ReadKey();
        }
    }
}