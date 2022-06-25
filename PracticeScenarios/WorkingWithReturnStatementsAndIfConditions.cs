using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    public class WorkingWithReturnStatementsAndIfConditions
    {
        public static void ReturnAndIfPractice()
        {
            var firstName = GetFirstName();
            var middleName = GetMiddleName();
            var lastName = string.Empty;

            var fullName = $"{firstName} {middleName} {lastName}";

            if (!string.IsNullOrWhiteSpace(lastName))   //(!= is does not equal.) (|| means or) (! is not)
            {
                Console.WriteLine(fullName);
            }
            else
            {
                Console.WriteLine("last name is empty");
            }
        }

        /// <summary>
        ///     creates a variable of type string and returns variable
        /// </summary>
        /// <returns>string</returns> 
        private static string GetFirstName()
        {
            var firstName = "Jarrod";
            return firstName;
        }

        /// <summary>
        ///     returns a string without creating a variable
        /// </summary>
        /// <returns>string</returns>
        private static string GetMiddleName()
        {
            return "Andrew";
        }

    }
    public class ReturnStatementVideo
    {
        public static void CubePractice()
        {
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);


            static int cube(int num)
            {
                int result = num * num * num;  //* = multiply 
                return result;
            }
        }
    }
    public class IfStatementVideo
    {
        public static void IfStatementPractice()
        {
            bool isMale = true;
            bool isTall = false;

            if (isMale && isTall)                    // && = and
            /*if(isMale || isTall)*/                    // || = or, now only one condition has to be met 
            {
                Console.WriteLine("You are a tall male.");               //only runs when true when both bools are set to true
            }
            //else
            else if (isMale && !isTall)             //! negation operator. In this case, means is not tall 
            {
                Console.WriteLine("You are a short male.");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male, but you are tall.");
            } else
            {
                Console.WriteLine("You are not male and not tall");          //this allows the program to run whether bools are true or false, regardless of order

            }

        }

    }
    public class ConditionsVideo
    {
        public static void Conditions()
        {
            Console.ReadLine();
        }
         // stopping point for video
        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {

            }
        }
    }
        
}

