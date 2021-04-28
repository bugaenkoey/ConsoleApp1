using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyListEnum
{
    partial class MyList<T> : IEnumerable<T>, ICollection<T>
    {
        public MyList()
        {
            Clear();
            
        }

        public int Count { get; set; }

        public bool IsReadOnly => false;
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public Node<T> Current { get; set; }
        public int Index { get; set; }
        public void Add(T value)
        {
            //  Node<T> node = new Node<T>(value);

            Current = new Node<T>(value);

            if (Head == null) Head = Tail = new Node<T>(value);

            Tail.Next = Current;
            Current.Previev = Tail;
            Tail = Current;
            Count++;
        }

        public void Clear()
        {
            Head = null;
            Index = -1;
            Count = 0;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public class Node<T2>
        {
            public Node()
            {
            }

            public Node(T2 value)
            {
                Value = value;
            }

            public Node(T2 value, Node<T2> next) : this(value)
            {
                Next = next;
            }

            public T2 Value { get; set; }
            public Node<T2> Next { get; set; } = null;
            public Node<T2> Previev { get; set; } = null;

            public override string ToString()
            {
                return Value.ToString();
            }
        }

        private class Enumerator<T2> : IEnumerator<T2>
        {
            private MyList<T2> myLists;

            public Enumerator(MyList<T2> myLists)
            {
                this.myLists = myLists;
            }

            public T2 Current =>  throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
              return  myLists.Current.Next != null;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
