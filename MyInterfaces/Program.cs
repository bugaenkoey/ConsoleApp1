using System;
using System.Collections;
using System.Collections.Generic;

            /*вставка, удаление, добавление объектов, элементов по индексу
             * IList Определяет коллекцию, доступ к которой можно получить 
             * с помощью индексатора
             *IEnumerable Определяет метод GetEnumerator(), предоставляющий 
             *перечислитель для любого класса коллекции
             *IEnumerator Предоставляет методы, позволяющие получать содержимое
             *коллекции по очереди
             *
             **/

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
         //   List<int> list = new List<int>();
            Console.WriteLine("Реализация интерфейса Ilist");

            int[] mas = new[]{ 1,2,3,4,5,6};


            MyList<int> myList = new MyList<int>();
            myList.Add(11);
            myList.Add(12);
            myList.Add(13);
            myList.Add(14);

            foreach (var item in myList)
            {
                Console.WriteLine(item.ToString());
            }

            myList.CopyTo(mas,4);

           var index= myList.IndexOf(11);

            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine( $"13 indexOf {myList.IndexOf(1)}");

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            MyList<string> listString = new MyList<string>();
            listString.Add("Один");
            listString.Add("Два");
            listString.Add("Три");
            listString.Add("Четыре");

            foreach (var item in listString)
            {
                Console.WriteLine(item);
            }


            MyList<int> myList2 = new MyList<int>();
            myList2.Add(21);
            myList2.Add(22);
            myList2.Add(23);
            myList2.Add(24);

            MyList<int> myList3 = new MyList<int>();
            myList3.Add(31);
            myList3.Add(32);
            myList3.Add(33);
            myList3.Add(34);

            MyList<MyList<int>> allList = new MyList<MyList<int>>();
            allList.Add(myList2);
            allList.Add(myList3);
            allList.Add(myList);
         //   allList.Add((IList)listString);
            foreach (var item in allList)
            {
                Console.WriteLine(item);
                foreach (var itemIList in item)
                {
                    Console.WriteLine(itemIList);
                }
            }

            Console.WriteLine();

        }
    }
}
