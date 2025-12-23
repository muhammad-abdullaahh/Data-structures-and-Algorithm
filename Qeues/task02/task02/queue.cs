using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class queue
    {
        Node front = null;
        Node rear = null;
        bool IsEmpty()
        {
            return front == null;
        }
        public void Enqueue(int x)
        {
            Node newNode = new Node();
            newNode.data = x;
            newNode.next = null;
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
                Console.WriteLine("{0} inserted into queue", x);
            }
        }
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("Element removed: " + front.data);
            front = front.next;
            if (front == null) // if queue becomes empty
                rear = null;
        }
        public void Peek()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is empty");
            else
                Console.WriteLine("Front element is: " + front.data);
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.Write("Queue elements: ");
            Node temp = front;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
