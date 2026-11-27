using System.Security.Cryptography;
using System.Threading.Channels;

namespace Demo
{

    internal class Program
    {

        static void Main(String[] args)
        {
            #region question 1
            //  Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.

            string title = "clean code";
            string upperTitle = title.ToUpper();
            
            Console.WriteLine("Original title: " + title);
            Console.WriteLine("Uppercase title: " + upperTitle);

            #endregion

        }
    }
}
