using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithCalculators
    {
        public static void CalculatorPractice()
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble (Console.ReadLine());

            Console.Write("Enter Operator:");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //== equals
            if (op == "+") 
            {
                Console.WriteLine(num1 + num2);

                // subtraction
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } 
            // division
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            //multiplication
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }

    }
}
