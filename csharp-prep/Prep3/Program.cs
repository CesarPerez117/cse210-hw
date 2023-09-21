using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int randomMagicNumber = randomGenerator.Next(1,101);
        int magicNumber = randomMagicNumber;
        Console.WriteLine("Guess the secret magic number!");
        
        /*Console.Write("What is the magic number? ");
        string magicNumberStr = Console.ReadLine();
        int magicNumber = int.Parse(magicNumberStr);*/

        /* I started getting the magic number from the user.
        then, I called this open variable to allow de do-while for the guessin numbers.
        Also, the attemps variable that adds 1 value for every try while guessing.*/
        int guessNumber = 0;
        int attemps = 0;

        do
        {
            Console.Write("What is your guess? ");
            string guessNumberStr = Console.ReadLine();
            guessNumber = int.Parse(guessNumberStr);
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
                attemps += 1;
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
                attemps += 1;
            }
        } while (guessNumber != magicNumber);
        
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Your tried {attemps} times.");
        
        
    }
}