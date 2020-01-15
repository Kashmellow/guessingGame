using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess = 7;
            int userGuess = 0;
            int i = 0;
            while (userGuess != numberToGuess)
            {
                i++;
                if (i == 2)
                    break;
                Console.Write("Can you guess the magic number between 1-10? Enter your guess: ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("{0} is too high!", userGuess);
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("{0} is too low!", userGuess);
                }
                
                else
                {
                    Console.WriteLine("{0} is right! You are magical. Congratulations.", userGuess);
                }
                if (userGuess == 0)
                {
                    Console.WriteLine("You little rebel. The number is between 1-10. Try being sneaky again and see what happens! ");
                    break;
                }

            }
        }
    }
}