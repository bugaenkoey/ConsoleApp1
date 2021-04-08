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

            Repository<MyElement> repository = new Repository<MyElement>("TestBook1");
            var r = repository.GetAllData();

            Console.Read();
        }
    }
}
