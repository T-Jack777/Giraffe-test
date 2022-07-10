using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_test.PracticeScenarios
{
    internal class WorkingWithClassesAndObjects
    {
        //video segment introduction discusses how to create a class
        //Jarrod taught you this and you've been using it regularly. 
        public static void ClassesAndObjectsVideoPractice()
        {
            //creating an object
            var bookOne = new Book("Harry Potter", "J.K.Rowling", 400);

            //Book book1 = new Book();
            //book1.title = "Harry Potter";
            //book1.author = "J.K. Rowling";
            //book1.pages = 400;


            var bookTwo = new Book("LOTR", "J.R.R Tolkien", 700);

            //Book book2 = new Book();
            //book2.title = "LOTR";
            //book2.author = "J.R.R Tolkien";
            //book2.pages = 700;

            // lines 30 and 32 are specifically for ClassesAndObjectsVideoPractice
            //Console.WriteLine(book1.title);

            //Console.WriteLine(book2.author);

            Console.WriteLine(bookOne.Pages);

            Console.WriteLine(bookTwo.Author);

            Console.ReadLine(); 
        }
    }
    //info based on the video specifically, creating a class
    class Book
    {
        //class attributes -- blueprint for book data type
        public string Title;
        public string Author;
        public int Pages;

        //Constructor--special method within the class that gets called when we create an object of that class
        //lines below are for the constructor segment of the video
        public Book(string title, string author, int pages)
        {
            // this works the same as typing out book1.title
            Title = title;
            Author = author;
            Pages = pages;
        }

    }
}
