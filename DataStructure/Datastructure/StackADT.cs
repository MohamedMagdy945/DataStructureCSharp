using System;
using System.Text;
namespace DatastructureAndAlogrithms.Datastructure
{
    internal class StackADT<T>
    {
        private T[] stack;
        private int top;
        private int size;
        public StackADT(int size)
        {
            if (size <= 0)
                throw new IndexOutOfRangeException("invalid size");
            this.size = size;
            stack = new T[size];
            top = -1;
        }
        public bool IsFull()
        {
            return top == size - 1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public void Push(T item)
        {
            if (IsFull())
                throw new IndexOutOfRangeException("stack overflow");
            stack[++top] = item;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("stack is empty");
            return stack[top--];
        }
        public T Top()
        {
            if (IsEmpty())
                throw new IndexOutOfRangeException("stack is empty");
            return stack[top];
        }
        public void Print()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write($"{stack[i]} ");
            }
            Console.WriteLine();
        }
        public void ReplaceAllElement(T olditem, T newitem)
        {
            for (int i = top; i >= 0; i--)
            {
                if (stack[i].Equals(olditem))
                    stack[i] = newitem;
            }
        }
        public void Revers()
        {
            for (int i = top; i > top / 2; i--)
            {
                T temp = stack[i];
                stack[i] = stack[top - i];
                stack[top - i] = temp;
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = top; i >= 0; i--)
            {
                s += $"{stack[i]} ";
            }
            return s;
        }
        public bool IsBalance(string exp)
        {
            if (exp.Length == 0)
                throw new Exception("expression is empty");
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(')
                    Push((T)(object)'(');
                else if (exp[i] == ')')
                {
                    if (IsEmpty()) return false;
                    else
                        Pop();
                }
            }
            return IsEmpty();
        }
        bool IsOperand(char s)
        {
            if (s == '*' || s == '/' || s == '+' || s == '-' || s == '%' || s == '(' || s == ')')
                return false;
            return true;
        }
        int OperatorPriorty(char s)
        {
            if (s == '(' || s == ')')
                return 3;
            else if (s == '*' || s == '/')
                return 2;
            else if (s == '+' || s == '-')
                return 1;
            else
                return 0;
        }
        public string InfixToPostfix(string exp)
        {

            StringBuilder Postfix = new StringBuilder();
            if (exp.Length == 0)
                throw new Exception("no expression");
            for (int i = 0; i < exp.Length; i++)
            {
                if (IsOperand(exp[i]))
                {
                    Postfix.Append(exp[i]);
                }
                else
                {
                    if (IsEmpty())
                    {
                        Push((T)(object)exp[i]);
                    }
                    else
                    {
                        while (!IsEmpty() && OperatorPriorty(exp[i]) <= OperatorPriorty((char)(object)Top()))
                        {
                            Postfix.Append(Pop());
                        }
                        Push((T)(object)exp[i]);
                    }
                }
            }
            while (!IsEmpty())
                Postfix.Append(Pop());
            return Postfix.ToString();
        }


        public double EvaluatePostfix(string exp)
        {
            StackADT<double> st = new StackADT<double>(exp.Length);
            string postfix = InfixToPostfix(exp);
            Console.WriteLine(postfix);

            for (int i = 0; i < postfix.Length; i++)
            {
                if (IsOperand(postfix[i]))
                {
                    st.Push((double)postfix[i] - 48);
                }
                else
                {
                    double v2 = st.Pop();
                    double v1 = st.Pop();
                    switch (postfix[i])
                    {
                        case '+': st.Push(v1 + v2); break;
                        case '-': st.Push(v1 - v2); break;
                        case '*': st.Push(v1 * v2); break;
                        case '/': st.Push(v1 / v2); break;
                    }
                }
            }
            return st.Pop(); ;
        }

    }
}