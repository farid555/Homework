using System;
using System.Collections.Generic;

namespace exercise_113 {
    class Program {
        public static void Main (string[] args) {
            // IMPLEMENT YOUR CODE IN HERE!
            // Remember also to create the file Book.cs and class in it!
            List<Book> books = new List<Book> ();

            while (true) {
                //name or title
                Console.Write ("Name: ");
                string title = Console.ReadLine ();
                if (title == "") {
                    break;
                }
                //ask for amount of pages
                Console.Write ("Pages: ");
                int pages = Convert.ToInt32 (Console.ReadLine ());

                //ask for pub year
                Console.Write ("Publication year: ");
                int year = Convert.ToInt32 (Console.ReadLine ());

                //add bbok information to list
                books.Add (new Book (title, pages, year));
            }
            //blank line
            Console.WriteLine ();

            //what we want to see
            Console.Write ("What information will be printed? ");
            string inputfromuser = Console.ReadLine ();

            //list the books, redid this part of exe
            //first attem to much code

            foreach (Book item in books) {
                if (inputfromuser == "title") {
                    //print only title
                    Console.WriteLine (item.title);
                } else if (inputfromuser == "everything") {
                    //print everything
                    Console.WriteLine (item);
                } else {
                    break;
                }
            }
        }
    }
}