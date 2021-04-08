using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryCRUD
{
    class MyElement
    {
        public MyElement()
        {
            Count++;
            Name = $"MyElement {Count}";
        }

        public MyElement(int id):this()
        {
            Id = id;
           
        }

        static int Count { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
