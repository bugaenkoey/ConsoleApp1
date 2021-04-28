using System;
using System.Collections.Generic;

namespace MyListEnum
{
    /*Задание 1: 
     * Используя код для реализации собственного связного списка, 
     * реализующего интерфейсы IEnumerable<T> и ICollection<T>
     * реализовать для него интерфейс IList<T>,
     * а также привести примеры использования разных операций 
     * (вставка, удаление, добавление объектов, элементов по индексу и т.д.).
    */
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> mList = new MyList<int>();
            mList.Add(88);
            mList.Add(77);
            mList.Add(55);
            mList.Add(44); 
            mList.Add(33);
            mList.Add(22);

            while (mList.Current.Next!=null)
            {
                Console.WriteLine(mList.Current);
            }
           
            foreach (var item in mList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
