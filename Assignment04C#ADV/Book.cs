using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03_C_ADV
{
    #region 1.Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:

    public class Book
    {
        public string ISBN { get; set; }

        public string Title { get; set; }

        public string[] Anthors { get; set; }

        public DateTime PublicationDate { get; set; }

        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Anthors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Anthors = _Anthors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            return $"ISBN = {ISBN} \n Title = {Title} \n Anthors = {string.Join(" , ", Anthors)} \n PublicationDate= {PublicationDate} \n Price ={Price: C}  ";
        }

    }


    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return $" Title = {B.Title}";
        }

        public static string GetAnthors(Book B)
        {
            return $" Anthors = {string.Join(" , ", B.Anthors)}";
        }

        public static string GetPrice(Book B)
        {
            return $"Price = {B.Price.ToString("C")}";
        }





    }
    #endregion


    #region 2.You need to parameterize ProcessBooks function to 
    public static class LibraryEngine
    {

        public static void ProcessBooks(List<Book> bList, Func<Book, string> fptr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fptr(B));
            }
        }


    }

    #endregion






}
