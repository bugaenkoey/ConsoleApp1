using System;
using System.Data.SqlClient;

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
        static void Main(string[] args)
        {



            //////////////////
            MyElement myElement = new MyElement();
            myElement.Id = 8;
            myElement.Name = "testElement";
            //myElement.Count = 88;

            Repository<MyElement> repository = new Repository<MyElement>("TestBook1");
            repository.AddElement(new MyElement(1, "t1"));
            repository.AddElement(new MyElement(2, "t2"));
            repository.AddElement(new MyElement(3, "t3")); 
            repository.AddElement(new MyElement(4, "t4"));
            repository.AddElement(new MyElement(5, "t5"));
            repository.AddElement(new MyElement(6, "t6"));
            repository.AddElement(new MyElement(7, "t7"));
            repository.AddElement(new MyElement(8, "t8"));
            repository.AddElement(new MyElement(9, "t9"));

            Repository<Book> repository2 = new Repository<Book>();
            repository2.AddElement(new Book("Book11","Avtor 11",111,1991));
            repository2.AddElement(new Book("Book21", "Avtor 11", 101, 1918));
           // repository2.AddElement(new Book());
         //   repository2.AddElement(new Book());

            repository.DeleteElement(8);
            var r = repository.GetAllData();
            var r2 = repository2.GetAllData();
            Console.Read();
        }
    }
}
