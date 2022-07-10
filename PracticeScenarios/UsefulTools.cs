using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    // if a class is static, you cannot create an instance of that class. 
    // example: UsefulTools tools = new UsefulTools(); would give an error message.
    // there would be no error message if it was listed as "class" only.
    // Jarrod Lesson-- IUsefulTools is an "Interface". 
    static class UsefulTools /*: IUsefulTools*/ // static classes also cannot utilize an interface
    {
        // public static requires a return type to function. "Void" is the return type in this case. 
        public static void SayHi(string name)
        {

            //Console.WriteLine("Hello " + name);
            Console.WriteLine(GetString(name));
        }

        private static string GetString(string name)
        {
            return "Hello " + name;
        }
    }
}
