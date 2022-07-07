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
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
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
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            // static attribute
            // this will tell us how many objects have been created in the Song class
            // the info is specific to the whole class, rather than one of the specific objects of the class. 
            songCount++;
        }
    }
    // if a class is static, you cannot create an instance of that class. 
    // example: UsefulTools tools = new UsefulTools(); would give an error message.
    // there would be no error message if it was listed as "class" only.
    static class UsefulTools
    {
        // public static requires a return type to function. "Void" is the return type in this case. 
        public static void SayHi(string name)
        {

            Console.WriteLine("Hello " + name);
        }
    }
}
