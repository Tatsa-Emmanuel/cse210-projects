using System;

class Program
{
    static void Main(string[] args)
    {

        Random number = new Random();
        int magicNumber = number.Next(1, 101);

        int guess = -1;
        int count = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            
        } 
        Console.WriteLine($"You made {count} guesses.");                   
    }
}