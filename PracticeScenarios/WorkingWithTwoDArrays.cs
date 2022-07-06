using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithTwoDArrays
    {

        public static void WorkingWithVideoTwoDArrays()
        {
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4}, 
                {4, 5}


            };

            //int[,] myArray = new int[2, 3];

            //square brackets call from:
            //1. The placement within the number grid and
            //2. The placement within the called element

            Console.WriteLine(numberGrid[2, 0]);



            Console.ReadLine();

        }

    }
}
