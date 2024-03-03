using System;

class Program
{
    static void Main(string[] args)
    {
        //For part 1 I wrote:
        //Console.WriteLine("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        //I do not consider necesary the first question if I want a guess game.


        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess;

        Console.WriteLine("What is your guess? ");

        do
        {
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {    
                Console.WriteLine("You guessed it");
            }
        } while (guess != magicNumber);
    }
        

}
