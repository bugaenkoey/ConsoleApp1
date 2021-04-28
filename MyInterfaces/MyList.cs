using System.Collections;
using System.Collections.Generic;

namespace MyInterfaces
{
    internal class MyList<T> : IList<T>
    {
        public Node<T> Head { get; set; }
        public int Count { get; set; }
        //   public int Index { get; private set; }

        public bool IsReadOnly => false;
        public MyList()
        {
            Count = 0;
            //  Index = -1;
            Head = null;
        }

        /*   public T this[int index] 
           { 
               get => throw new System.NotImplementedException();
               set => throw new System.NotImplementedException();
           }*/
        //++++++++++++++
        public T this[int index]
        {
            get
            {
                /*               if (index >= 0 && index < this.Count-1)
                               {
                                   return this[index];
                               }
                               // throw new("IndexOutOfRangeException"); //IndexOutOfRangeException();
                               return default(T);
                */

                return this[index];
            }
            set
            {
                this[index] = value;
            }
        }
        //----------------


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



        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> currentNode = Head;
            if (currentNode == null) return;

            while (arrayIndex < array.Length && Count - arrayIndex >= 0)
            {
                array[arrayIndex] = currentNode.Value;
                currentNode = currentNode.Next;
                arrayIndex++;
            }
        }

        public bool Contains(T value)
        {
            foreach (var item in this)
            {
                if (item.Equals(value)) return true;
            }
            return false;
        }


        public int IndexOf(T value)
        {
            if (Head == null) return -1;
            for (int i = 0; i < this.Count - 1; i++)
            // foreach (var item in this)
            {
                // var en = GetEnumerator();

                var x = this[i];
                if (this[i].Equals(value))
                {
                    return i;
                }

                /*              if (item.Equals(value))
                 *              
                              {

                              }*/
            }

            return 1000000;
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

        private class Enumerator<T2> : IEnumerator<T2>
        {
            private MyList<T2> myLists = null;
            private Node<T2> currentNode = null;
            public int index = -1;

            public Enumerator(MyList<T2> myLists)
            {
                this.myLists = myLists;
            }

            public T2 Current => currentNode.Value;

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
                currentNode = null;
                index = -1;
            }
        }
    }
}