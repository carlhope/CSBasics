using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    public class Book
    {
        public readonly string Title;

        public readonly int Pages;

        //public readonly int CurrentPage = 1;
        public int CurrentPage { get; private set; } = 1;

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        public void TurnPage()
        {
            if(CurrentPage < Pages)
            {
                CurrentPage++;
            } else
            {
                Console.WriteLine("New page does not exist.");
            }
            
        }
    }
}
