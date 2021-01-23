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

            int[] numbers = new [] { 1, 2, 3 };
            //IEnumerable xEnumerable = numbers.
            // Console.WriteLine(xEnumerable.ToString());
 /*           IEnumerable
            IEnumerator enumeratorNumbers = numbers.GetEnumerator();
            while (enumeratorNumbers.MoveNext())
            {
                Console.WriteLine(enumeratorNumbers.Current);
            }
*/

            List<int> myList = new List<int>() { 1, 6, 0 };
            myList.Add(8);
            myList.Add(7);
            //  myList.Clear();
            myList.Add(9);
            myList.Add(5);


            //   myList = new List<int>();

            myList.Add(3);
            // myList.Clear();
            myList.Add(2);
            foreach (var item in myList)
            {
                Console.WriteLine($"Вывод: {item}");
            }
            Console.WriteLine(myList.Contains(77) ? "yes" : "no");

            List<MyClass> listMyClass = new List<MyClass>(new MyClass());
            for (int i = 0; i < 5; i++)
            {

                listMyClass.Add(new MyClass());
            }


            foreach (var item in listMyClass)
            {
                item.Print();
            }
        }
        public class MyClass
        {
            public static int count = 0;
            public int Namer { get; set; }
            public MyClass()
            {
                count++;
                Namer = count;
            }
            public void Print()
            {
                Console.WriteLine($"MyClass{Namer}");
            }
        }

    }
}
