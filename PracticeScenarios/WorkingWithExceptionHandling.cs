using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithExceptionHandling
    {
        public static void ExceptionHandlingVideoPractice()
        {

            try
            {
                Console.Write("Enter a number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            //setting up the catch method this way allows the program to tell you what the error is.
            //catch (Exception e)
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            //any code in the finally block gets executed no matter what
            //finally
            //{

            //}

            //Console.Write("Enter a number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            ////without exception handling:
            ////entering something like a 0 or a letter will stop the program and start debugging
            //Console.WriteLine(num1 / num2);

            //Console.ReadLine();
        }
    }
}
