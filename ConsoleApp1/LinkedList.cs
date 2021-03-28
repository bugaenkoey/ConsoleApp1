using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
//namespace ConsoleApp1
{
    public class LinkedList<T> : ICollection<T>, IEnumerable<T>
    {
        public bool IsReadOnly => false;

        public Node<T> Head { get; set; }

        public int Count { get; }

        public LinkedList() { }

        public LinkedList(T headValue)
        {
            Head = new Node<T>(headValue);
            Count = 1;
        }

        public LinkedList(IEnumerable<T> values)
        {
            IEnumerator<T> enumerator = values.GetEnumerator();
            Node<T> currentNode;

            if (enumerator.MoveNext())
            {
                Head = new Node<T>(enumerator.Current);
                currentNode = Head;

                Count = 1;
            }
            else
            {
                return;
            }

            while (enumerator.MoveNext())
            {
                Node<T> newNode = new Node<T>(enumerator.Current);
                currentNode.Next = newNode;
                currentNode = newNode;
                Count++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            Node<T> currentHead = Head;
            Node<T> newHead = new Node<T>(item, currentHead);
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
            Node<T> currentNode = Head;
            if (currentNode == null) return;

            while (arrayIndex < array.Length && Count - arrayIndex >= 0)
            {
                array[arrayIndex] = currentNode.Value;
                currentNode = currentNode.Next;
                arrayIndex++;
            }
        }

        public bool Remove(T item)
        {
            Node<T> current = Head;

            if (current.Value.Equals(item))
            {
                Head = current.Next;
                return true;
            }

            Node<T> previous = Head;

            current = current.Next;

            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    previous.Next = current.Next;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }
    }

    public class Enumerator<T> : IEnumerator<T>
    {
        private LinkedList<T> list = null;
        private Node<T> currentNode = null;
        private int index = -1;

        public Enumerator(LinkedList<T> linkedList)
        {
            list = linkedList;
        }

        public bool MoveNext()
        {
            currentNode = index < 0 ? list.Head : currentNode.Next;
            index++;
            return currentNode != null;
        }

        public void Reset()
        {
            currentNode = null;
            index = -1;
        }

        public T Current => currentNode.Value;

        object IEnumerator.Current => Current;

        public void Dispose() { }
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

