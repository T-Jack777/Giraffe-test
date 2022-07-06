using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithExponentMethod
    {
        public static void ExponentMethodVideoPractice()
        {
            Console.WriteLine(GetPow(3, 6));
            Console.ReadLine();
        }
        static int GetPow(int baseNum, int powNum)
        {
            var result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;

            }

            return result;

        }
    }
}
