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
            var student1 = new Student("Jim", "Philosophy", 2.8);
            var student2 = new Student("Pam", "Art", 3.5);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();

        }
    }

    class Student
    {
        public string Name;
        public string Major;
        public double Gpa;

        public Student(string name, string major, double gpa)
        {
            Name = name;
            Major = major;
            Gpa = gpa;
        }
        //creating a method 
        public bool HasHonors()
        {
            //you are able to change the true/false outcome by only editing here
            //if (Gpa >= 2.5)
            var result = Gpa >= 2.5 ? true : false;
            
            //if (Ga >= 3.5)
            {
                // return statment below is necessary. Otherwise, HasHonors populates an error. 
                return true;
            }
            //return false;
        }
    }
}
