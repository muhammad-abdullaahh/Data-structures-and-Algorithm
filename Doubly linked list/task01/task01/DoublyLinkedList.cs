using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class DoublyLinkedList
    {
        private Node head;
        //Insert a node at end
        public void insertAtEnd(int data)
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
        //Insert at beginning
        public void insertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        //Delete a node
        public void Delete(int data)
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
        //Display List
        public void Display()
        {
            Node temp = head;
            Console.Write("Doubly linked list: ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}

