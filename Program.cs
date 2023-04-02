// See https://akusing System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cute and Funny Mad Libs Game!");

            Console.Write("Enter an adjective: ");
            string adjective1 = Console.ReadLine();

            Console.Write("Enter a type of animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a noise: ");
            string noise = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb1 = Console.ReadLine();

            Console.Write("Enter a place: ");
            string place = Console.ReadLine();

            Console.Write("Enter an emotion: ");
            string emotion = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("Enter another adjective: ");
            string adjective2 = Console.ReadLine();

            Console.WriteLine("\nHere's your Mad Libs story:\n");

            Console.WriteLine($"Once upon a time, there was a {adjective1} {animal} named Fluffy. Fluffy loved to make {noise} noises all day long. One day, Fluffy decided to {verb1} to the {place} to find some new friends. Along the way, Fluffy felt {emotion} and stumbled upon a group of {pluralNoun}. They all looked so {adjective2} that Fluffy couldn't help but join them!");

            Console.WriteLine("\nThanks for playing! Press any key to exit.");
            Console.ReadKey();
        }
    }
}