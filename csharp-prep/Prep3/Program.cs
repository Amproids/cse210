using System;

class Program
{
    static void Main(string[] args)
    {
        bool playing = true;
        while (playing) {
            bool numberGuessed = false;
            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());
            int numberOfGuesses = 0;
            while (numberGuessed == false) {
                Console.Write("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());
                numberOfGuesses += 1;
                if (guess > magicNumber) {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber) {
                    Console.WriteLine("Higher");
                }
                if (magicNumber == guess) {
                    numberGuessed = true;
                }
            }
            Console.WriteLine($"You guessed it! You got it in {numberOfGuesses} guesses.");
            Console.Write("Would you like to play again? (Type 'yes') ");
            if (Console.ReadLine() == "yes") {
                playing = true;
            }
            else {
                playing = false;
            }
        }
    }
}