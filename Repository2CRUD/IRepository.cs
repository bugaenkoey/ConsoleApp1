using System;
using System.Collections.Generic;
using System.Text;

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
        List<T> GetAllData();
        T GetElementById(int id);
        void AddElement(T element);
        void ChangeElement(T element);
        void DeleteElement(int id);
    }
}
