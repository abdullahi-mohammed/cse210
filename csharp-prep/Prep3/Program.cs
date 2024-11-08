using System;
using System.Security.Cryptography;

//  What is the magic number? 18
//   What is your guess? 5
//   Higher
//   What is your guess? 6
//   Higher
//   What is your guess? 7
//   Higher
//   What is your guess? 20
//   Lower
//   What is your guess? 19
//   Lower
//   What is your guess? 18
//   You guessed it!
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess the magic number right to win!");
        Random random = new Random();
        int magicNum = random.Next(1, 101);
        int guess;
        do
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magicNum != guess);

    }


}