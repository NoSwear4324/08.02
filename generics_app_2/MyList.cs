using System.Security.Cryptography.X509Certificates;

namespace generics_app_2
{
    public class Node<T>
    {
        public T? Data { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T? data)
        {
            Data = data;
            Next = null;
        }
    }

public class MyList<T>
{
    private Node<T>? Head;
    private Node<T>? Tail;

    public int Count { get; set; }
    
    public MyList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public void AddLast(T data) //Add last 0(1)
    {
        
    }

    public void AddFirst(T data) //Add first 0(1)
    {
        
    }
}
}

