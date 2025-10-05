using System;

namespace task01
{
    internal class Stack
    {
        static readonly int max = 1000;
        int top, count;
        int[] stack = new int[max];

        public Stack()
        {
            top = -1;
            count++;
        }

        public bool isEmpty()
        {
            return (top < 0);
        }

        public bool isFull()
        {
            return (top == max - 1);
        }

        public bool push(int data)
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

        public void peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow...");
            }
            else
            {
                Console.WriteLine($"The top most element of the stack is {stack[top]}");
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
                Console.WriteLine("Items in the stack are:");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        public void countItems()
        {
            Console.WriteLine("The number of items in the stack are {0}",top+1);
        }
    }
}
