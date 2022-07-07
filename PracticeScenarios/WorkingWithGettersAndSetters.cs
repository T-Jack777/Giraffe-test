using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithGettersAndSetters
    {
        public static void GettersAndSettersVideoPractice()
        {

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            //G, PG, PG-13, R, NR

            avengers.Rating = "PG-13";
            Console.WriteLine(avengers.Rating);

            // comment back in below for result "Invalid Rating"
            //avengers.Rating = "Dog";
            //Console.WriteLine(avengers.Rating);

            Console.ReadLine();

        }

        class Movie
        {
            public string movieName;
            public string director;
            //getters and setters are needed due to the private string under the Movie class
            private string rating;

            public Movie(string aMovieName, string aDirector, string aRating)
            {
                movieName = aMovieName;
                director = aDirector;
                //the capital R calls the setter below when the capital rating is used
                rating = aRating;
            }

            public string Rating
            {
                get { return rating; }
                set {


                    if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")

                    {

                        rating = value;
                    }

                    else
                    {
                        rating = "Invalid Rating";
                    }
                }
            }
        }
    }
}
