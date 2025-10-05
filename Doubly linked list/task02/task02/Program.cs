using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task02;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList cll = new CircularLinkedList();

            cll.insertAtBeginning(10);
            cll.insertAtEnd(20);
            cll.insertAtEnd(30);
            cll.insertAtEnd(40);
            cll.insertAtEnd(50);

            Console.WriteLine("List after inserting elements:");
            cll.Display();

            cll.insertAtBeginning(5);
            Console.WriteLine("\nAfter inserting 5 at the beginning:");
            cll.Display();

            cll.Delete(30);
            Console.WriteLine("\nAfter deleting 30:");
            cll.Display();

            cll.Delete(5);
            Console.WriteLine("\nAfter deleting head (5):");
            cll.Display();

            cll.Delete(50);
            Console.WriteLine("\nAfter deleting last node (50):");
            cll.Display();
        }
    }
}
