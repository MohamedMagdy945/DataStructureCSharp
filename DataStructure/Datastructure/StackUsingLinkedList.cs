using System;
namespace Datastructure.Datastructure
{
    internal class N<T>
    {
        internal T item; 
        public N<T> Next = null;
    }
    internal class StackUsingLinkedList<T>
    {

        private N<T>[] stack;
        private N<T> top;
        public StackUsingLinkedList()
        {   
            top =null;
        }
       
        public void push(T item)
        {
            N<T> NewItem = new N<T>();
            NewItem.item = item;
            NewItem.Next = top;
            top = NewItem;
        }
        public bool IsEmpty()
        {
            return top == null; 
        }
        public T pop(T item)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack if full");
                return default(T);
            }
            else
            {
                N<T> Temp = top;
                top = top.Next;
                return Temp.item;
            }   
        }
        public void Display()
        {
            N<T> temp = top;
            while(temp != null)
            {
                Console.WriteLine($"{temp.item} ");
                temp = temp.Next;
            }
        }
    }
}
