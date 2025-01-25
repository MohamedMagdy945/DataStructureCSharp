using System;
using System.Collections.Generic;
using System.Drawing;
namespace Datastructure.Datastructure
{
    class Node<T>
    {
        internal T item;
        internal Node<T> Next = null;
    }
    internal class GenericLinkedList<T>
    {
        Node<T> Head;
        Node<T> Last;
        int length;
        public GenericLinkedList() { 
            Head = null;
            Last = null;
        }
        public bool IsEmpty()
        {
            return Head == null;
        }
        public void InsertFirst(T item)
        {
            Node<T> NewItem = new Node<T>();
            if (IsEmpty())
                Last = NewItem;
            NewItem.item = item;
            NewItem.Next = Head;
            Head = NewItem;
            length++;
        }
        public void InsertLast(T item)
        {
            Node<T> NewItem = new Node<T>();
            NewItem.item = item;
            if (IsEmpty())
            {
                Head = NewItem;
                Last = NewItem;
                return;
            }
            Last.Next = NewItem;
            Last = NewItem;
            length++;
        }
        public void InsertAtPos(int pos ,T item )
        {
            if ( pos < 0 || pos > length)
                Console.WriteLine("Out Of Range");            
            else if (length == 0)
                InsertFirst(item);
            else if ( length == pos )
                InsertLast(item);
            else
            {
                Node<T> current = Head;
                int count = 0;
                while (current.Next != null)
                {
                    if (count++ == pos)
                    {
                        Node<T> NewItem = new Node<T>();
                        NewItem.item = item;
                        NewItem.Next = current.Next;
                        current.Next = NewItem;
                        length++;
                        return;
                    }
                    current = current.Next;
                }
            }
        }
        public void DeletFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Head = Head.Next;
            if (Head == null)
                Last = null;
            length--;
        }
        public void DeletLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Linked List is empty");
            }
            else if (Head == Last)
            {
                Head = null;
                length--;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next.Next != null)
                    current = current.Next;
                Last = current;
                current.Next= null;
                length--;
            }
        }
        public void DeleltAtPos(int pos)
        {
            if (pos < 0 && pos >= length)
            {
                Console.WriteLine("Out Of Range");
                return;
            }
            else if (length == 0)
            {
                Console.WriteLine("Lisked List is empty");
                return;
            }
            else if (Head == Last)
                Head = null;
         
            else
            {
                if (pos == 0) Head= Head.Next;
                else
                {
                    Node<T> current = Head;
                    int count = 0;
                    while (current.Next != null)
                    {
                        if (++count == pos)
                            current.Next = current.Next.Next;
                        current = current.Next;
                    }
                }
            }
            length--;
        }
        public void Reverse()
        {
            if (Head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Last = Head;
            Node<T> prev = Head;
            Node<T> temp = Head.Next;
            ref Node<T> current =ref Head;
            current.Next = null;
            while (temp != null)
            {
                current = temp;
                temp = temp.Next;
                current.Next = prev;
                prev = current;
            }
        }
        public int SearchElememnt(T e)
        {
            int pos= 0;
            if (Head == null)
            {
                Console.WriteLine("Linked List is empty");
                return -1 ;
            }
            Node<T> temp = Head;
            while (temp != null)
            {
                if (EqualityComparer<T>.Default.Equals(e,temp.item)) return pos;
                pos++;
                temp = temp.Next;
            }
            return -1 ;
        }
        public void Display()
        {
            if (!IsEmpty())
            {
                Node<T> temp = Head;
                while (temp != null)
                {
                    Console.Write($"{temp.item} ");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
            else Console.WriteLine("LinkedList is Empty");
        }
        
    }
}
