    using System;
    using System.Net;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Exercise3 Project.");
            Random randomGenerator = new Random();
            string response;
            
            
            do {
                int guessCount = 0;
                int number = randomGenerator.Next(1, 101);
                int guessNumber = -1;

                while (guessNumber != number)
                {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guessNumber = int.Parse(userGuess);
                guessCount += 1;

                    if (guessNumber > number)
                    {Console.WriteLine("Lower");
                    }
                    else if (guessNumber < number)
                    {Console.WriteLine("Higher");
                    }
                
                }
            
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You made {guessCount} guesses!");

                Console.Write("Do you want to continue? ");
                response = Console.ReadLine();

            } while (response.ToLower() == "yes");
        }
}