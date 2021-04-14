using System;

namespace Repository2CRUD
{
    class Book : IElementId
    {
        public Book()
        {
            RandomBook();
        }

        public Book(string nameBook, string autor, int pages, int year, int count)
        {
            NameBook = nameBook;
            Autor = autor;
            Pages = pages;
            Year = year;
            Count = count;
        }

        public int Id { get; set; }

        public string NameBook { get; set; }
        public string Autor { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public int Count { get; set; }


        public override string ToString()
        {
            return $"Id = {Id}\tNameBook = {NameBook}\tAutor = {Autor}\tPages{Pages}\tYear = {Year}\tCount = {Count}\n";
        }
        public void RandomBook()
        {
            Random random = new Random();
            Pages = random.Next(10, 1000);
            Year = random.Next(1900, DateTime.Now.Year);
            Count = random.Next(0, 10);
            for (int i = 0; i < random.Next(5, 20); i++)
            {
                NameBook += $"{(char)random.Next('A', 'z' + 1)}";

            }
            for (int i = 0; i < random.Next(5, 20); i++)
            {
                Autor += $"{(char)random.Next('A', 'z' + 1)}";

            }

        }
    }
}
