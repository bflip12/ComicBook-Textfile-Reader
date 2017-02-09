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
    class ComicBook
    {
        private string publisher;
        private string title;
        private int issue;
        private string date;
        private decimal bookValue;
        private decimal marketValue;

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
        public string GetPublisher()
        {
            return publisher;
        }
        /// <summary>
        /// returns the objects title parameter
        /// </summary>
        /// <returns>string containing title</returns>
        public string GetTitle()
        {
            return title;
        }
        /// <summary>
        /// returns the objects issue parameter
        /// </summary>
        /// <returns>int containing issue</returns>
        public int GetIssue()
        {
            return issue;
        }
        /// <summary>
        /// returns the objects date parameter
        /// </summary>
        /// <returns>string containing date</returns>
        public string GetDate()
        {
            return date;
        }
        /// <summary>
        /// returns the objects bookvalue parameter
        /// </summary>
        /// <returns>decimal containing bookvalue</returns>
        public decimal GetBookValue()
        {
            return bookValue;
        }
        /// <summary>
        /// returns the objects marketvalue parameter
        /// </summary>
        /// <returns>decimal containing marketvalue</returns>
        public decimal GetMarketValue()
        {
            return marketValue;
        }
        /// <summary>
        /// changes the objects publisher value to the parameter value
        /// </summary>
        /// <param name="publisher"></param>
        public void SetPublisher(string publisher)
        {
            this.publisher = publisher;
        }
        /// <summary>
        /// changes the objects title value to the parameter value
        /// </summary>
        /// <param name="title">title value set by user</param>
        public void SetTitle(string title)
        {
            this.title = title;
        }
        /// <summary>
        /// changes the objects issue value to the parameter value
        /// </summary>
        /// <param name="issue">issue value set by user</param>
        public void SetIssue(int issue)
        {
            this.issue = issue;
        }
        /// <summary>
        /// changes the objects date value to the parameter value
        /// </summary>
        /// <param name="date">date value set by user</param>
        public void SetDate(string date)
        {
            this.date = date;
        }
        /// <summary>
        /// changes the objects bookvalue value to the parameter value
        /// </summary>
        /// <param name="bookValue">bookvalue value set by user</param>
        public void SetBookValue(decimal bookValue)
        {
            this.bookValue = bookValue;
        }
        /// <summary>
        /// changes the objects marketvalue value to the parameter value
        /// </summary>
        /// <param name="marketValue">marketvalue value set by user</param>
        public void SetMarketValue(decimal marketValue)
        {
            this.marketValue = marketValue;
        }

       /// <summary>
       /// returns a formatted string containing the parameters of the comicbook object to the console
       /// </summary>
        public void displayComic()
        {
           Console.WriteLine("{0,-10}  {1,-25}  {2,-5}  {3,-15}  {4,-10}  {5,-10}",  publisher,  title,  issue,  date,  bookValue,  marketValue);
        }
    }
}
    