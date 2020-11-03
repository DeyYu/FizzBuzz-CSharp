using FizzBuzz.Services;
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzService fizzBuzzService = new FizzBuzzService();
            for (int i = 1;i<=100;i++)
            {
                var fizzBuzzString = fizzBuzzService.GetFizzBuzz(i);
                Console.WriteLine(fizzBuzzString);
            }
            Console.ReadLine();
        }
    }
}
