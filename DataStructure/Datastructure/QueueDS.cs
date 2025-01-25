using System;
namespace Datastructure.Datastructure
{
    internal class QueueDS
    {
        int _size;
        int front;
        int rear;
        int[] queue;
        int length;
        public QueueDS(int size)
        {
            queue = new int[size];
            _size = size;
            rear = -1;
            front = -1;
        }
        public bool isEmpty()
        {
            return front == -1 && rear == -1;
        }
        public bool isFull()
        {
            return (rear + 1) % _size == front;
        }
        public void enqueue(int num)
        {
            if (isFull())
            {
                Console.WriteLine("queue is full");
                return;
            }
            if (isEmpty())
                front = 0;

            rear = (rear + 1) % _size;
            queue[rear] = num;
        }
        public int dequeue()
        {
            int x;
            if (isEmpty())
            {
                Console.WriteLine("queue is empty");
                x = -1;
            }
            else if (front == rear)
            {
                x = queue[rear];
                front = rear = -1;

            }
            else
            {
                x = queue[front];
                front = (front + 1) % _size;
            }
            return x;
        }
        public void Display()
        {

            if (isEmpty()) Console.WriteLine("queue is empty");
            else
            {
                for (int i = front; i != rear; i = (i + 1) % _size)
                {
                    Console.Write($"{queue[i]} ");
                }
                Console.WriteLine(queue[rear]);
            }
        }
        public int SearchIndex(int num)
        {
            int count = 1;
            if (isEmpty())
            {
                Console.WriteLine("queue is empty");
                return -1;
            }
            else
            {
                for (int i = front; i != rear; i = (i + 1) % _size)
                {
                    if (queue[i] == num)
                        return count;
                    count++;
                }
                if (queue[rear] == num) return count;
            }
            return -1;
        }
        public void GetArrow()
        {
            Console.WriteLine($"front : {front} , rear : {rear}");
        }
    }
}
