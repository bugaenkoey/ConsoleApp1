using System;
using System.Collections;
using System.Collections.Generic;

namespace MyInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Реализация интерфейса Ilist");
            /*вставка, удаление, добавление объектов, элементов по индексу
             * IList Определяет коллекцию, доступ к которой можно получить с помощью индексатора
             *IEnumerable Определяет метод GetEnumerator(), предоставляющий перечислитель для любого класса коллекции
             *IEnumerator Предоставляет методы, позволяющие получать содержимое
             *коллекции по очереди
             *
             **/
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
            Console.WriteLine(myList.Contains(77)?"yes":"no");

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
