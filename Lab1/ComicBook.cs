//I, Bobby Filippopoulos, student number 000338236, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.
// The programs purpose is to be able to read a text file that contains a list of comicbook, each comicbook contains details
// the program will be to display the list of comicbook in a sorted format that is decided by the user
// Date created: 1/22/2017
// Date last modified: 2/3/2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Contains the parameters of the comicbook object, constructor and get/set methods
    /// </summary>
    class ComicBook : IComparable<ComicBook>
    {
        public string publisher { get; set; }

        public string title { get; set; }

        public int issue { get; set; }

        public string date { get; set; }

        public decimal bookValue { get; set; }

        public decimal marketValue { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public ComicBook() { }
        /// <summary>
        /// this constructor sets the parameters of the ComicBook object
        /// </summary>
        /// <param name="publisher">string containing publisher name</param>
        /// <param name="title">string containing title of the book</param>
        /// <param name="issue">int containing the issue number of the book</param>
        /// <param name="date">string containing the date written, formatted in main using DateTime allowing sorting</param>
        /// <param name="bookValue">decimal containing the original value</param>
        /// <param name="marketValue">decimal containing the market value of the book</param>
        public ComicBook(string publisher, string title, int issue, string date, decimal bookValue, decimal marketValue)
        {
            this.publisher = publisher;
            this.title = title;
            this.issue = issue;
            this.date = date;
            this.bookValue = bookValue;
            this.marketValue = marketValue;
        }
        /// <summary>
        /// returns the objects publisher parameter
        /// </summary>
        /// <returns></returns>

 

       /// <summary>
       /// returns a formatted string containing the parameters of the comicbook object to the console
       /// </summary>
        public void displayComic()
        {
           Console.WriteLine("{0,-10}  {1,-25}  {2,-5}  {3,-15}  {4,-10}  {5,-10}",  publisher,  title,  issue,  date,  bookValue,  marketValue);
        }

        public static ComicBookComparer GetComparer()
        {
            return new ComicBook.ComicBookComparer();
        }
        public int CompareTo(ComicBook rhs)
        {
            return this.issue.CompareTo(rhs.issue);
        }

        public int CompareTo(ComicBook rhs, ComicBook.ComicBookComparer.ComparisonType Which)
        {
            switch(Which)
            {
                case ComicBook.ComicBookComparer.ComparisonType.issue:
                    return this.issue.CompareTo(rhs.issue);
                case ComicBook.ComicBookComparer.ComparisonType.publisher:
                    return this.publisher.CompareTo(rhs.publisher);
                case ComicBook.ComicBookComparer.ComparisonType.title:
                    return this.title.CompareTo(rhs.title);
                case ComicBook.ComicBookComparer.ComparisonType.date:
                    return this.date.CompareTo(rhs.date);
                case ComicBook.ComicBookComparer.ComparisonType.bookValue:
                    return this.bookValue.CompareTo(rhs.bookValue);
                case ComicBook.ComicBookComparer.ComparisonType.marketValue:
                    return this.marketValue.CompareTo(rhs.marketValue);
            }
            return 0;
        }

        public class ComicBookComparer
        {
            public class ComparisonType
            {
            }
        }
    }
}
    