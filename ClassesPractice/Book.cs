using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPractice
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int PageCount { get; set; }
        public string Genre { get; set; }
        public int CalculateProgress(int currentPageNumber)
        {
            return currentPageNumber / PageCount;
        }
    }
}
