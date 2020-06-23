using System;

namespace SelectionStatements2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");





            var random = new Random();
            var number = random.Next(1,1000);


            var userInput = int.Parse(Console.ReadLine());




            if (userInput < number)
            {
                Console.WriteLine($"Too low. sorry!");
            }


            else if (userInput > number)
            {
                Console.WriteLine($"Too high. sorry!");

            }

            else 
            {
                Console.WriteLine($"Nevermind!!");

            }

        }

    }
}
