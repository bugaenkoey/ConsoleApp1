using System;
using System.Collections;
using System.Collections.Generic;

namespace MyInterfaces
/**
 * 
 * 
namespace System.Collections.Generic
{
//
// Сводка:
//     Exposes the enumerator, which supports a simple iteration over a collection of
//     a specified type.
//
// Параметры типа:
//   T:
//     The type of objects to enumerate.
public interface IEnumerable<out T> : IEnumerable
{
    //
    // Сводка:
    //     Returns an enumerator that iterates through the collection.
    //
    // Возврат:
    //     An enumerator that can be used to iterate through the collection.
    IEnumerator<T> GetEnumerator();


    ----------------

namespace System.Collections
{
    //
    // Сводка:
    //     Exposes an enumerator, which supports a simple iteration over a non-generic collection.
    public interface IEnumerable
    {
        //
        // Сводка:
        //     Returns an enumerator that iterates through a collection.
        //
        // Возврат:
        //     An System.Collections.IEnumerator object that can be used to iterate through
        //     the collection.
        IEnumerator GetEnumerator();
    }
}
 * */
{
    class Program
    {

        //OwnLinkedList
        static void Main(string[] args)
        {
            Console.WriteLine("Реализация интерфейса Ilist");
            /*вставка, удаление, добавление объектов, элементов по индексу
             * IList Определяет коллекцию, доступ к которой можно получить 
             * с помощью индексатора
             *IEnumerable Определяет метод GetEnumerator(), предоставляющий 
             *перечислитель для любого класса коллекции
             *IEnumerator Предоставляет методы, позволяющие получать содержимое
             *коллекции по очереди
             *
             **/

            MyList<int> myList = new MyList<int>();
            myList.Add(11);
            myList.Add(22);
            myList.Add(33);
            myList.Add(44);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

        }
    }
}
