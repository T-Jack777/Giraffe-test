﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithInheritance
    {

        // one class can inherit all functionality of another class
        public static void InheritancePracticeVideo()
        {

            Chef chef = new Chef();

            ItalianChef italianChef = new ItalianChef();

            chef.MakeChicken();

            italianChef.ItalianChefCooksSpaghetti();

            italianChef.MakeChicken();

            chef.MakeSpecialDish();

            italianChef.MakeSpecialDish();

            Console.ReadLine();

        }
    }

    class Chef
    {
      public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");

        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        // the virtual keyword is required to perform an override to the subclass if needed. 
        // virtual allows subclasses to change the functionality of the method.
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes a bbq ribs");
        }

    }

    // Italian Chef can do all the same things that the regular Chef can do. 
    // Class 1 : Class 2 -- this executes inheritance. 
    // Class 1 here is the subclass and Class 2 here is the superclass 
    // the subclass inherits functionality from the superclass
    class ItalianChef : Chef
    {
        public void ItalianChefCooksSpaghetti()
        {
            Console.WriteLine("Italian Chef cooks spaghetti.");

        }
        // for reference from the previous lesson, public static void will not execute properly, but public void will. 
        public static void ItalianChefCooksLasagna()
        {
            Console.WriteLine("Italian Chef cooks lasagna.");
        }

        // override is necessary to play off of the virtual keyword and create a different method in the subclass. 
        public override void MakeSpecialDish()
        {
            Console.WriteLine("Italian Chef makes Chicken Parmesan.");
        }

    }

}
