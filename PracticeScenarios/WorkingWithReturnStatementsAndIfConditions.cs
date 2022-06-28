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

            //(!= is does not equal.) (|| means or) (! is not)
            if (!string.IsNullOrWhiteSpace(lastName))   
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
                //* = multiply
                int result = num * num * num;   
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

            // && = and
            if (isMale && isTall)                    

            // || = or, now only one condition has to be met
            /*if(isMale || isTall)*/                     
            {
                //only runs when true when both bools are set to true
                Console.WriteLine("You are a tall male.");               
            }
            //else

            //! negation operator. In this case, means is not tall 
            
            else if (isMale && !isTall)              
            {
                Console.WriteLine("You are a short male.");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male, but you are tall.");


            }//this allows the program to run whether bools are true or false, regardless of order
            else
            {
                
                Console.WriteLine("You are not male and not tall");         

            }

        }

    }
    public class ConditionsVideo
    {
        public static void Conditions()
        {
            Console.WriteLine(GetMax(20, 10, 40));

            Console.ReadLine();
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            // > < >= && <= are comparison operators
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else 
            {
                result = num3;
            }

            return result;
        }
    }
        
}

