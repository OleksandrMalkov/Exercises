/*7.31 (Enhanced Guess the Number Game) Modify the app of Exercise 7.30 to count the number of guesses the player makes.
       If the number is 10 or fewer, display Either you know the secret or you got lucky! If the player guesses the number in 10 tries, display Aha! You know the secret! 
       If the player makes more than 10 guesses, display You should be able to do better! Why should it take no more than 10 guesses?
       Well, with each “good guess,” the player should be able to eliminate half of the numbers. Now show why any number from 1 to 1000 can be guessed in 10 or fewer tries.


 */
using System;
class Program
{
    static void Main(string[] args)
    {
        {
            Random randomNumbers = new Random();
            int random = randomNumbers.Next(1, 1000);

            Console.Write("Guess a number between 1 and 1000: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            int guessCounter = 1;
            while (guess != random)
            {
                if (guess < random)
                {
                    Console.Write("Too low. Try again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Too high. Try again: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                guessCounter++;
            }
            if (guess == random)
            {
                if (guessCounter < 10)
                    Console.WriteLine("Either you know the secret or you got lucky!");
                else if (guessCounter == 10)
                    Console.WriteLine("Aha! You know the secret!");
                else
                    Console.WriteLine("You should be able to do better!");
            }
            Console.ReadLine();
        }
    }
}