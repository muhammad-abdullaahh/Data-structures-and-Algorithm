using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task01;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            dll.insertAtBeginning(10);
            dll.insertAtEnd(20);
            dll.insertAtEnd(30);
            dll.insertAtEnd(40);
            dll.insertAtEnd(50);
            dll.Display();

        }
    }
}
