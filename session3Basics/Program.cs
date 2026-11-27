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

            int Pages = 464;

            if (Pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else {
                Console.WriteLine("Short Book");
            }

            #endregion



        }
    }
}
