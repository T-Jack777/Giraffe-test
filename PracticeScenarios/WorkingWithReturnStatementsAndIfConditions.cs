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
}
