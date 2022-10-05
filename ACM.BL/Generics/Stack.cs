using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Generics
{
    public sealed class Stack<T>
    {
        private Node<T> Head;
        private Node<T> Tail;
        private int index = 0;

        public Stack(Node<T> Top) 
        {
            Head = Top;
            for(Node<T> n = Top; n != null; n = n.Next)
            {
                Tail = n;
            }
        }

        public Stack()
        {
        }

        public bool IsEmpty()
        {
            return index == 0;
        }

        public void Push(T item)
        {
            Node<T> node = new Node<T>();
            node.Item = item;
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            index++;
        }

        public T Pop()
        {
            T item = Peek();
            for (Node<T> n = Head; n != null; n = n.Next) 
            {
                if (n.Next == Tail)
                {
                    n.Next = null;
                    Tail = n;
                    index--;
                } 
            }
            return item;
        }

        public T Peek()
        {
            if (Tail == null)
                return default(T);
            return Tail.Item;
        }

        public void Clear()
        {
            index = 0;
            Tail = null;
            Head = null;
        }

        public int Count()
        {
            return index;
        }
    }
}
