using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(101);
            int specifiedNumber1 = 3;
            int specifiedNumber2 = 5;

            Console.WriteLine("Случайное число: "+number);
            Console.ReadLine();

            for (int i = specifiedNumber1, j = specifiedNumber2; i <= number; i += 3, j += 5)
            {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                    Console.ReadLine();
                }
            }
        }
    }