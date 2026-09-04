using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int secretNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;

        while (guess!= secretNumber)
        {
            Console.Write("Guess a number. ");
            guess = int.Parse(Console.ReadLine());
            guessCount = guessCount + 1;
        
            if (secretNumber > guess)
            {
                Console.WriteLine("Higher");

            }
            else if (secretNumber < guess)
            {
                Console.WriteLine ("Lower");

            }
            else
            {
                Console.WriteLine("You got the number!");
                Console.WriteLine($"It took you {guessCount} guesses");
            }
            
        }
        

    }
}