using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsWithCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game");
            bool isGuessed = false;
            bool decision;
            do
            {
                // Generate Random Number
                var rand = new Random();
                int num = rand.Next(0, 50);
                // Test random generator 
                //Console.WriteLine($"Test - Answer number {num}");
                int counter = 0;
                // loop through the game until number guess
                while (!isGuessed)
                {
                    // Get the guessed number
                    Console.WriteLine("Enter an integer greater" +
                        " than or equal to 0 and less than 50");
                    int guesNumber = Convert.ToInt32(Console.ReadLine());

                    if (guesNumber == num)
                    {
                        Console.WriteLine("You guessed the correct number.");
                        isGuessed = true;
                    }
                    else if (guesNumber < num)
                    {
                        Console.WriteLine("Your guess is lower than the number.\nGuess again!");

                    }else if ( counter < 3)
                    {
                        // Give the player 3 attemp before giving the answer;
                        Console.WriteLine($"Third attemp, the number is {num}");
                    }else
                    {
                        Console.WriteLine("Your guess is higher than the number.\nGuess again!");
                    }
                    // increment counter
                    counter++;
                }

                // Wait for End key
                Console.WriteLine("Do you wish to try again? True or false");
                decision = Convert.ToBoolean(Console.ReadLine());
                isGuessed = false;
            } while ( decision);
        }
    }
}
