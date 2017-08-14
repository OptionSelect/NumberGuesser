using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            var guessCount = 0;
            Random rnd = new Random();
            var rando = rnd.Next(1, 100);
            Console.Write("Guess the number! ");
            var input = Console.ReadLine();

            while (int.Parse(input) != rando)
            {
                if (int.Parse(input) < rando)
                {
                    guessCount++;
                    Console.WriteLine("Your guess was too low. Try again.");
                    input = Console.ReadLine();
                }
                else if (int.Parse(input) > rando)
                {
                    guessCount++;
                    Console.WriteLine("Your Guess was too high. Try again.");
                    input = Console.ReadLine();
                }
            }
            guessCount++;
            Console.WriteLine($"You got it in {guessCount} tries!");
        }
    }
}
