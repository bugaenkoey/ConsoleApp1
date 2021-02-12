namespace MyInterfaces
{
    public class Node<T>

    {
        public Node(T value)
        {
             Value = value;
        }
        public Node(T value, Node<T> next):this(value)
        {        
            Next = next;         
        }
        public Node(T value, Node<T> next, Node<T> previe):this(value, next)
        {      
            Previe = previe;
        }

        public T Value { get; set; }

        public Node<T> Next { get; set; }
        public Node<T> Previe { get; set; }

      
    }
}