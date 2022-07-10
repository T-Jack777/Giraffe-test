using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithStatic
    {
        public static void StaticClassAttributesVideo()
        {
            var holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            var kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.ReadLine();
        }

        public static void StaticMethodsAndClassesVideo()
        {
            //method that belongs to the class. You don't have to make an instance for the class to use it. 
            //Console.WriteLine(Math.Sqrt(144));

            UsefulTools.SayHi("Travis");

            Console.ReadLine();
        }
    }
    class Song 
    {
        public string Title;
        public string Artist;
        public int Duration;
        public static int songCount = 0;

        public Song(string title, string artist, int duration)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            // static attribute
            // this will tell us how many objects have been created in the Song class
            // the info is specific to the whole class, rather than one of the specific objects of the class. 
            songCount++;
        }
    }
}
