using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasics
{
    public class Book
    {
        public string Title;

        public int Pages;

        public int CurrentPage = 1;

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
