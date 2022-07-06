using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    public class ForLoop
    {
        public static void ForLoopPractice()
        {
            var period = ".";
            int incrementalNumber;
            
            for (int i = 0; i < 10; i++)
            {
                incrementalNumber = i + 1;
                Console.WriteLine(incrementalNumber + period);
            }
        }

        public static void ForLoopVideoPractice()
        {

            //var i = 1;
            //while (i <= 5)
            //{

            //    Console.WriteLine(i);

            //    i++;
            //}

            //How to access elements inside an array
            //Call luckyNumbers
            //luckyNumbers[0] calls the 4. luckyNumbers[1] calls the 8, etc.
            
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            
            //1st is variable initiation
            //2nd is loop condition
            //3rd is line of code executed each time we go through the for loop
            
            for (var i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }


            Console.ReadLine();


        }
    }
}
