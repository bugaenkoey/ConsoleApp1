using System.Collections;
using System.Collections.Generic;

namespace MyInterfaces
{
    internal class MyList<T> : IList<T>
    {
        public Node<T> Head { get; set; }
        public int Count { get; private set; }
        public int Index { get; private set; }

        public bool IsReadOnly => false;
        public MyList()
        {
            Count = 0;
            Index = -1;
            Head = null;
        }

        public T this[int index] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }



        public void Add(T item)
        {
            if (Count == 0) Head = new Node<T>(item, null);
            if (Count > 0)
            {
                Head = new Node<T>(item, Head);
            }



            Count++;



        }

        public void Clear()
        {
            Head = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }



        public int IndexOf(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class Enumerator<T> : IEnumerator<T>
        {
            private MyList<T> myLists = null;
            private Node<T> currentNode = null;
            private int index = -1;

            public Enumerator(MyList<T> myLists)
            {
                this.myLists = myLists;
            }

            public T Current => currentNode.Value;

            object IEnumerator.Current => throw new System.NotImplementedException();

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                currentNode = index < 0 ? myLists.Head : currentNode.Next;
                index++;
                return currentNode != null;
            }

            public void Reset()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}