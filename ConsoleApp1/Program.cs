
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces
//namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 2, 3, 5 };
            // IList<T>
           

           //  List<int> standardList;
            LinkedList<int> list = new LinkedList<int>(numbers);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintNumbers(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}


