using System;
using System.Collections.Generic;
using System.Text;

namespace Repository2CRUD
{
    class Book : IElementId
    {
        public Book()
        {
            AllBook =$"Всего книг {++Count}";
        }

        public Book(string nameBook, string autor, int pages, int year)
        {
            NameBook = nameBook;
            Autor = autor;
            Pages = pages;
            Year = year;
        }

        public int Id { get ; set ; }
         
        public string NameBook { get; set; }
        public string Autor { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public static int Count { get; set; }
        public string AllBook { get; set; }
    }
}
