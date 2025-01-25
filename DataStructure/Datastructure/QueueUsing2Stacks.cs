using System;
namespace Datastructure.Datastructure
{
    internal class QueueUsing2Stacks
    {
        int top1 , top2;
        int _size1, _size2;
        int[] stack1;
        int[] stack2;
        public QueueUsing2Stacks(int size)
        {
            _size1 = _size2 = size;
            stack1 = new int[_size1];
            stack2 = new int[_size2];
            top1 = top2 = -1;
        }
        private bool isEmpty1()
        {
            return top1 == -1;
        }
        private bool isEmpty2()
        {
            return top2 == -1;
        }
        private bool isFull1()
        {
            return top1 == _size1 - 1;
        }
        private bool isFull2()
        {
            return top2 == _size1 - 1;
        }
        private void push1(int x)
        {
            if(isFull1())
            {
                Console.WriteLine("stack is full");
                return;
            }
            stack1[++top1] = x; 
        }
        private void push2(int x)
        {
            if (isFull2())
            {
                Console.WriteLine("stack is full");
                return;
            }
            stack2[++top2] = x;
        }
        private int pop1()
        {
            int x = -1;
            if(isEmpty1())
            {
                Console.WriteLine("stack if empty");
                return x;
            }
            return stack1[top1--];
        }
        private int pop2()
        {
            int x = -1;
            if (isEmpty2())
            {
                Console.WriteLine("stack if empty");
                return x;
            }
            return stack2[top2--];
        }
        public void enqueue(int x)
        {
            push1(x);
        }
        public int dequeue()
        {
            while(!isEmpty1())
                push2(pop1());
            int x = pop2();
            while(!isEmpty2())
                push1(pop2());
            return x;
        }
        public void Print()
        {
            if (isEmpty1())
            {
                Console.WriteLine("queue is empty");
                return;
            }
            for(int i = 0; i  <= top1 ; i++)
            {
                Console.Write(stack1[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
