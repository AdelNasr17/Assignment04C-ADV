using Assignment03_C_ADV;

namespace Assignment04C_ADV
{
    // a)Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
    public delegate string BookDelegate(Book B);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region accept BookFunctions Methods using following cases: 


            //c)Anonymous Method (GetISBN).
            Func<Book, string> GetISBN = delegate (Book B) { return B.ISBN; };

            //d)Lambda Expression (GetPublicationDate).
            Func<Book, string> GetPublicationDate = B => B.PublicationDate.ToString();
            #endregion


            //Use ProcessBooks

            List<Book> list = new List<Book>()
            {
                new Book("1" , "Databases" , new string[] {"Adel" , "Amr"} , DateTime.Now , 1000),
                 new Book("2" , "C# Basics" , new string[] {"Adel" , "Amr"} , DateTime.Now , 5000)
            };

            Func<Book, string> GetTitle = BookFunctions.GetTitle;

            LibraryEngine.ProcessBooks(list, GetTitle);
            LibraryEngine.ProcessBooks(list, GetISBN);
            LibraryEngine.ProcessBooks(list, GetPublicationDate);

        }
    }
}
