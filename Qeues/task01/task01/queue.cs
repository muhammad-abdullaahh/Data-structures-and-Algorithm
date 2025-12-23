using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class queue
    {
        int[] a = new int[3];
        int front = -1;
        int rear = -1;
        bool IsEmpty()
        {
            if (front == -1 && rear == -1)
                return true;
            else
                return false;
        }
    
        bool IsFull()
        {
            if (rear == a.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Enqueue(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else if (IsEmpty())
            {
                front = 0;
                rear = 0;
                a[rear] = x;
            }
            else
            {
                rear = rear + 1;
                a[rear] = x;
            }
            Console.WriteLine("{0} inserted into queue", x);
        }
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else if (front == rear)
            {
                Console.WriteLine("Element removed: " + a[front]);
                front = rear = -1;
            }
            else
            {
                Console.WriteLine("Element removed: " + a[front]);
                front = front + 1;
            }
        }
        public void Peek()
        {
            if (front == -1)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                Console.WriteLine("front element is: " + a[front]);
            }
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.Write("Queue elements: ");
            for (int i = front; i <= rear; i++)
                Console.Write(a[i] + " ");
            Console.WriteLine();
        }
    }
}
