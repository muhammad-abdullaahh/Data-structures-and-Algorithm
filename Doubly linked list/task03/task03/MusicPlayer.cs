using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class MusicPlayer
    {
        private Node head;
        //Insert a song at end
        public void insertAtEnd(String data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.prev = temp;
        }
        //Delete a node
        public void delete(String data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;
            // If head node is to be deleted
            if (temp.data == data)
            {
                head = temp.next;
                if (head != null)
                    head.prev = null;
                return;
            }
            while (temp != null && temp.data != data)
            {
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("Node not found in the list");
                return;
            }

            if (temp.next != null)
                temp.next.prev = temp.prev;

            if (temp.prev != null)
                temp.prev.next = temp.next;
        }
        //Traverse forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;
            Console.WriteLine("Forward:");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        //Traverse backward
        public void DisplayBackward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;
            while (temp.next != null) 
            {
                temp = temp.next;
            }

            Console.WriteLine("Backward:");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.prev;
            }
        }
    }
}
