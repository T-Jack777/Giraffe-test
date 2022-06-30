using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithGuessingGame
    {
        public static void GuessingGame()
        {

            var secretWord = "giraffe";
            string guess;
            var isFirstGuess = true;
            do
            {
                if(isFirstGuess)
                {
                    Console.WriteLine("Enter guess");
                    isFirstGuess = false;
                    guess = Console.ReadLine(); 
                    
                }
                else
                {
                    Console.WriteLine("Incorrect guess. Try again. ");
                    guess = Console.ReadLine();
                }
            }
            while (guess != secretWord);

            Console.Write("You Win!");



            Console.ReadLine();

        }
    }
}
