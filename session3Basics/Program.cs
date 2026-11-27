using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Demo
{

    internal class Program
    {

        static void Main(String[] args)
        {
            #region question 1
            //  Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.

            //string title = "clean code";
            //string upperTitle = title.ToUpper();

            //Console.WriteLine("Original title: " + title);
            //Console.WriteLine("Uppercase title: " + upperTitle);

            #endregion

            #region question 2
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.

            //string Name1 = "Clean Code";
            //string Name2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(Name1, Name2));

            #endregion

            #region question 3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.

            //StringBuilder sb = new StringBuilder("Book List");
            //sb.Append("- Update");

            //Console.WriteLine(sb);



            #endregion

            #region question 4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".Print the result.

            //StringBuilder sb = new StringBuilder("Book List");

            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);

            #endregion

            #region question 5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,Pages: 464" using the + operator

            //String title = "Clean Code";
            //int pages = 464;

            //String result = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(result);

            #endregion


            #region question 6
            //Build the same sentence as above, but using string interpolation ($"...").


            //String title = "Clean Code";
            //int pages = 464;

            //String result = $"Book : {title} , Pages : {pages}";
            //Console.WriteLine(result);

            #endregion

            #region question 7
            //Build the same sentence again, but using string.Format().



            //String title = "Clean Code";
            //int pages = 464;

            //String result = string.Format("Book : {0} , Pages : {1}", title, pages);
            //Console.WriteLine(result);

            #endregion

            #region question 8
            //Build the same sentence again, but using string.Format().

            //int Pages = 464;

            //if (Pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else {
            //    Console.WriteLine("Short Book");
            //}

            #endregion

            #region question 9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator.


            //int Pages = 464;
            //bool isAvailable = true;

            //if (Pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}


            #endregion

            #region question 10
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.Use the && operator.


            //int Pages = 464;
            //bool isAvailable = true;

            //if (Pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}


            #endregion

            #region question 11
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            //string title = "Refactoring";

            //switch (title) {

            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}



            #endregion

            #region question 13
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).

            //int Pages = 464;

            //string sizeLabel = Pages > 300 ? "Long Book" : "Short Book";

            //Console.WriteLine(sizeLabel);

            #endregion

            #region question 14
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.


            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine(books[i]);
            //}
            #endregion

            #region question 15
            //Using the same books array, use a while loop to print every book title.

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //int index = 0;
            //while (index < books.Length)
            //{
            //    Console.WriteLine(books[index]);
            //    index++;
            //}
            #endregion

            #region question 16
            //Write a do-while loop that prints "Checking book..." exactly 3 times.

            //int count = 0;
            //do {
            //    Console.WriteLine("Checking book...");
            //    count++;
            //} while (count < 3);



            #endregion

            #region question 17
            //Using the same books array, use a foreach loop to print every book title.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book in books) { 
            //    Console.WriteLine(book);
            //}



            #endregion

            #region question 18
            //Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring".

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                Console.WriteLine(book);
                if (book == "Refactoring")
                {
                    break;
                }
            }



            #endregion




        }
    }
}
