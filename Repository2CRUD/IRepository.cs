using System.Collections.Generic;

namespace Repository2CRUD
{
    /*
     Задание 1: 
Описать интерфейс IRepository<T>, который будет инкапсулировать в себе CRUD (create-read-update-delete) операции с данными:
•	получение всех данных
•	получение элемента по Id
•	Добавление элемента
•	Изменение элемента
•	Удаление элемента

    getting all data • getting an element by Id • Adding an element • Changing an element • Deleting an element
     */
    interface IRepository<T>
    {
        List<T> GetAll();
        T GetElementById(int id);
        void Add(T element);
        void ChangeElement(T element);
        void DeleteById(int id);
    }
}
