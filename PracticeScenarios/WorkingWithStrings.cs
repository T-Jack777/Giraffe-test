using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    public class WorkingWithStrings
    {
        /// <summary>
        ///     does nifty stuff with strings and stuff
        /// </summary>
        public static void StringsPractice()
        {
            var firstName = "Jarrod";
            var middleName = "Andrew";
            var lastName = "Jackson";
            var fullName = $"{firstName} {middleName} {lastName}"; //string interpolation
            var fullName2 = "Jarrod" + " Andrew" + " Jackson"; // string concatination
            var characterCount = fullName.Length;

            Console.WriteLine(fullName);
            Console.WriteLine($"fullName has printed with {characterCount} characters");
        }
    }
}
