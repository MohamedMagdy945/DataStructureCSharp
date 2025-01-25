using System;
namespace Datastructure.Datastructure
{
    internal struct Item
    {
        public int priorty;
        public int value;
    }
    internal class PriortyQueueDS
    {
        int _size;
        int front;
        int rear;
        Item[] queue;
        int length;
        public PriortyQueueDS(int size)
        {
            queue = new Item[size];
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
        public void enqueue(int value, int priorty)
        {
            if (isFull())
            {
                Console.WriteLine("queue is full");
                return;
            }
            if (isEmpty())
                front = 0;

            rear = (rear + 1) % _size;
            queue[rear].value = value;
            queue[rear].priorty = priorty;
            InsertionSortByPriorty(queue);
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
                x = queue[rear].value;
                front = rear = -1;

            }
            else
            {
                x = queue[front].value;
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
                    Console.Write($"{queue[i].value} : {queue[i].priorty} , ");
                }
                Console.WriteLine($"{queue[rear].value} : {queue[rear].priorty}");
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
                    if (queue[i].value == num)
                        return count;
                    count++;
                }
                if (queue[rear].value == num) return count;
            }
            return -1;
        }
        public void GetArrow()
        {
            Console.WriteLine($"front : {front} , rear : {rear}");
        }
        public void InsertionSortByPriorty(Item[] it)
        {
            int j = rear - 1;
            Item temp = it[rear];
            while (j >= front && temp.priorty < it[j].priorty)
            {
                it[j + 1] = it[j];
                j--;
            }
            it[j + 1] = temp;
        }
    }
} 


