using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ComicBookComparer : IComparer<ComicBook>
    {
        public ComicBook.ComicBookComparer.ComparisonType WhichComparison { get; set;}

        public enum ComparisonType
        {
            issue,
            publisher,
            title,
            date,
            bookValue,
            marketValue
        };
        public int Compare(ComicBook lhs, ComicBook rhs)
        {
            return lhs.CompareTo(rhs, WhichComparison);
        }
    }
}
