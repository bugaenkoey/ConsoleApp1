using System;
using System.Linq;

namespace MyStrRevert
{
    class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            Reader reader = new Reader();
            reader.SeeBooks(library);

            Console.Read();
        }
    }

    class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }

    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
    interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }
    class Book
    {
        public string Name { get; set; }
    }

    class Library : IBookNumerable
    {
        private Book[] books;
        public Library()
        {
            books = new Book[]
            {
            new Book{Name="Война и мир"},
            new Book {Name="Отцы и дети"},
            new Book {Name="Вишневый сад"}
            };
        }
        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
    class LibraryNumerator : IBookIterator
    {
        IBookNumerable aggregate;
        int index = 0;
        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Book Next()
        {
            return aggregate[index++];

            /*
                        string sentence = "Hey wollef sroirraw";
                        var words = sentence.Split(' ');
                        string newString = string.Empty;
                        for (int j = 0; j < words.Length; j++)
                        {
                            if (words[j].Length >= 5)
                            {
                                string stringRevers = string.Empty;
                                for (int i = words[j].Length; i > 0; i--)
                                {
                                    stringRevers += words[j][i - 1];
                                }
                                words[j] = stringRevers;
                            }
                            newString += words[j];
                            newString += " ";
                        }

                        newString = newString.Trim();
                        Console.Write(newString);
                        Console.WriteLine("WWW");

                        Console.Write(String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str)));//);
                        Console.WriteLine("WWW");

                        Console.WriteLine(Mango(3, 3));
                        Console.WriteLine(Mango(9, 5));

                        var ar = PreFizz(5);


                    }
                    public static int Mango(int quantity, int price)
                    {
                        //quantity / 3 * 2 * price;

                        return quantity / 3 * 2 * price;
                    }
                    public static int[] PreFizz(int n)
                    {

                        int[] array = new int[n];
                        for (int i = 0; i < n;)
                        {
                            array[i] = ++i;
                        }

                        // int[] array = Enumerable.Range(1, n).ToArray();
                        return array;
                    }
                    public static string Maskify(string cc)
                    {

                        return "";
            */
        }
    }
}
