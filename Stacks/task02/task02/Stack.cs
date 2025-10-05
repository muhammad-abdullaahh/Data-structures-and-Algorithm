using System;

namespace task02
{
    internal class Stack
    {
        static readonly int max = 1000;
        int top;
        char[] stack = new char[max];

        public Stack()
        {
            top = -1;
        }
        public bool push(char data)
        {
            if (top >= max - 1)
            {
                Console.WriteLine("Stack overflow...");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty");
                return 0;
            }
            else
            {
                return stack[top--];
            }
        }
        public void displayStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow...");
            }
            else
            {
                Console.WriteLine("The reversed string is: ");
                for (int i = top; i >= 0; i--)
                {
                    Console.Write(stack[i]);
                }
            }
        }
    }
}
