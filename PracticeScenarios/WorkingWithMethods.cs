using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    public class WorkingWithMethods
    {
        public static void MethodsPractice()    //methods are listed in caps
        {
            SayHi("Travis", 29); //this gives hello a place to call from
            SayHi("Jarrod", 33);
            SayHi("JP", 30);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age); // anything can be passed in, strings, ints, bools, doubles, etc. 
        }

    }
}
