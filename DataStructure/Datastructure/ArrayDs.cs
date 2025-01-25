using System;
using System.Linq;
namespace Datastructure.Datastructure
{
    internal class ArrayDs<T>
    {
        T[] arr;
        int size;
        int length;
        public ArrayDs(int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("invalid size");
            this.size = size;
            arr = new T[size];
        }
        public bool isEmpty()
        {
            return length == 0;
        }
        public bool isFull()
        {
            return size == length;
        }
        public void add(T t)
        {
            if (!isFull())
                arr[length++] = t;
            else throw new IndexOutOfRangeException("Array is Full");
        }
        public void InsertAt(int index, T t)
        {
            if (!isFull())
            {
                for (int i = length; i >= index; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[index - 1] = t;
                length++;
            }
        }
        public void Display()
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public ArrayDs<T> Clone()
        {
            ArrayDs<T> arr2 = new ArrayDs<T>(size);
            for (int i = 0; i < length; i++)
            {
                arr2.add(arr[i]);
            }
            return arr2;
        }
        public T IndexOf(int x)
        {
            return arr[x];
        }
        public T GetValue(int index)
        {

            if (index > length && index < 0)
            {
                throw new IndexOutOfRangeException("Not found");
            }
            return arr[index];
        }
        public void Delet()
        {

        }


    }
}
