using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithWhileLoops
    {
        public static void WhileLoopPractice()
        {

            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);

                //++ adds 1 onto the index
                index++;
            }

            Console.ReadLine();
        }

        public static void DoWhileLoopPractice()
        {

            int index = 6;
            do
            {
                Console.WriteLine(index);

                index++;
            } while (index <= 5);

            Console.ReadLine();
        }
    }

 
}
