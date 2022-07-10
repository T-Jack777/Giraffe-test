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

            var avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            var shrek = new Movie("Shrek", "Adam Adamson", "PG");

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
            public string MovieName;
            public string Director;
            //getters and setters are needed due to the private string under the Movie class
            private string rating;

            public Movie(string movieName, string director, string rating)
            {
                MovieName = movieName;
                Director = director;
                //the capital R calls the setter below when the capital rating is used
                Rating = rating;
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
