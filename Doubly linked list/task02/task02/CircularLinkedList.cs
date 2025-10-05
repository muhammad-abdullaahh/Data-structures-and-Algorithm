using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class CircularLinkedList
    {
        private Node head;

        // Insert a node at end
        public void insertAtEnd(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                head.next = head;
                head.prev = head;
                return;
            }

            Node last = head.prev;
            last.next = newNode;
            newNode.prev = last;
            newNode.next = head;
            head.prev = newNode;
        }

        // Insert at beginning
        public void insertAtBeginning(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                head.next = head;
                head.prev = head;
                return;
            }

            Node last = head.prev;
            newNode.next = head;
            newNode.prev = last;
            head.prev = newNode;
            last.next = newNode;
            head = newNode;
        }

        // Delete a node
        public void Delete(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;
            Node prevNode = null;

            // Single node case
            if (head.next == head && head.data == data)
            {
                head = null;
                return;
            }

            // Head node case
            if (head.data == data)
            {
                Node last = head.prev;
                head = head.next;
                head.prev = last;
                last.next = head;
                return;
            }

            // Traverse to find node
            do
            {
                if (temp.data == data)
                    break;

                prevNode = temp;
                temp = temp.next;

            } while (temp != head);

            if (temp == head)
            {
                Console.WriteLine("Node not found in the list");
                return;
            }

            prevNode.next = temp.next;
            temp.next.prev = prevNode;
        }

        // Display list
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;
            Console.Write("Circular Doubly Linked List: ");
            do
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine();
        }
    }
}
