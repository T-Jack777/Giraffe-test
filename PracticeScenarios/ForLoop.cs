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
    }
}
