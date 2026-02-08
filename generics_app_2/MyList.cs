using System;
using System.Collections.Generic;
using System.Text;

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
        public Node<T>? Head;
        public Node<T>? Tail;
        public int Count { get; set; }
        public MyList()
        {
            Head = null; 
            Tail = null; 
            Count = 0;
        }
        public void AddLast(T data) //Add last O(1)
        {
            Node<T> newNode = new Node<T>(data);
            if(Head == null)
            {
                Head = Tail = newNode;
                return;
            }
            Tail?.Next = newNode;
            Tail = newNode;
        }
        public void AddFirst(T data) //Add first O(1)
        {

        }
        //Додати методи:
        //ToString, Find, Sort, this["First"], this["Last"]
        //Reverse, Clear, Contains, Remove(T item),
        //RemoveLast, RemoveFirst
        //InsertAfter(T Value) -> Вставити новий елемент, після першого входження T Value
        //InsertBefore(T Value) -> Вставити новий елемент, перед першого входження T Value
        //SwapPairs() -> Поміняти місцями кожну пару сусідніх нод приклад:
        //Було: 1 -> 2 -> 3 -> 4 -> 5 -> null
        //Стало: 2 -> 1 -> 4 -> 3 -> 5 -> null
        //
        public override string ToString()
        {
            string result = "";
            Node<T>? current = Head;
            while(current != null)
            {
                result += current.Data + "\t";
                current = current.Next;
            }
            return result;
        }
    }
}