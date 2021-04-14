using System;
using System.Collections.Generic;

namespace Repository2CRUD
{
    /*
     * «Платформа Microsoft .NET и язык программирования C#»
Тема: Шаблон проектирования «репозиторий» (хранилище)
Цель: 
•	изучение библиотек .NET; 
•	приобретение практических навыков работы с основными шаблонами проектирования. 
Задание 1: 
Описать интерфейс IRepository<T>, который будет инкапсулировать в себе 
    CRUD (create-read-update-delete) операции с данными:
•	получение всех данных
•	получение элемента по Id
•	Добавление элемента
•	Изменение элемента
•	Удаление элемента
Задание 2: 
Реализовать интерфейс классом Repository<T>, который будет производить
    непосредственные манипуляции с данными.
В текущей реализации репозиторий будет инкапсулировать работу с таблицей данных. 
    Например класс Repository<Book> будет реализовывать доступ к таблице Books.

*/
    class Program
    {
        static void Main()
        {
            // Repository<MyElement> repository = new Repository<MyElement>("Test");

            Repository<Book> repositoryBook = new Repository<Book>();

            CreateElement(repositoryBook);
            int id = 6;
            repositoryBook.DeleteById(id);

            ShowElements(repositoryBook.GetAll());

            var book = new Book("NewBook5", "NewAutor5", 555, 5555, 55);
            id = 5;
            repositoryBook.ChangeElement(id, book);

            ShowElements(repositoryBook.GetAll());

            Console.WriteLine(repositoryBook.GetElementById(id).ToString());
            Console.Read();
        }

        private static void CreateElement<T>(Repository<T> repository) where T : new()
        {
            for (int i = 0; i < 10; i++)
            {
                repository.Add(new T());
                // book.RandomBook();
            }
        }



        private static void ShowElements(List<Book> elements)
        {
            foreach (var item in elements)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
