using System;
using System.Collections;
using System.Collections.Generic;

namespace MyInterfaces
{
    class List<T> : ICollection<T>, IEnumerable<T>
    {

        public int Count { get; set; }
        public bool IsReadOnly => false;
        public Node<T> Head { get; set; }
        public List() { }
        public List(T value)
        {
            Count = 1;
            Head = new Node<T>(value);
        }
        public void Add(T value)
        {
            Node<T> addNode = Head;
            Head = new Node<T>(value, addNode);
            Count++;
        }

        public void Clear()
        {
            Head = null;
        }

        public bool Contains(T item)
        {
            foreach (T collectionItem in this)
            {
                if (collectionItem.Equals(item)) return true;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class Enumerator<T> : IEnumerator<T>
        {
            private List<T> list;
            private int index = -1;
            private Node<T> itemNode = null;
            public Enumerator(List<T> lists)
            {
                this.list = lists;
            }

            public T Current => itemNode.Value;

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                Console.WriteLine("End");
            }

            public bool MoveNext()
            {
                itemNode = index < 0 ? list.Head : itemNode.Next;
                // return index != -1 ? false : true;
                index++;
                return itemNode != null;
            }

            public void Reset()
            {
                itemNode = null;
                index = -1;
            }
        }
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            Value = value;
        }
        public Node(T value, Node<T> next)
        {
            Value = value;
            Next = next;
        }
    }

}
