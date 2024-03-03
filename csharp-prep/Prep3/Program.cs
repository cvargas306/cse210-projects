using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int userNumber = int.Parse(Console.ReadLine()); 
        
        Random random = new Random();
        int userNumber = random.Next(1,101);

        int userGuess = -1;


         while (guess != userNumber)
        {
            Console.WriteLine("What is your guess?" );
            string guess = Console.ReadLine();
            int userGuess = int.Parse(guess);

            if (userNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }

            else if (userNumber > userGuess);
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it");
            }

        }

        
    }
}