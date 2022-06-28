using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithSwitchStatements
    {
        public static void SwitchStatementPractice()
        {
            Console.WriteLine(GetDay(7));

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";

                    //break out of the structure you are currently in
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;

                default:

                    dayName = "Invalid Day Number";
                    break;

                    // everything you can do with switch statements you can do with if statements. 
                    // switch statements are typically easier to read



            }


            return dayName;

        }

    }
}
