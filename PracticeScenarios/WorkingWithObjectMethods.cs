using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithObjectMethods
    {
        //method that can be defined within a class
        
        public static void ObjectMethodsVideoPractice()
        {
            Student student1 = new Student("Jim", "Philosophy", 2.8);
            Student student2 = new Student("Pam", "Art", 3.5);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();

        }
    }

    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }
        //creating a method 
        public bool HasHonors()
        {
            //you are able to change the true/false outcome by only editing here
            if (gpa >= 2.5)
            //if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
