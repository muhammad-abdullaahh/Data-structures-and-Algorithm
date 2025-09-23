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
            LinkedList llist = new LinkedList();

            llist.append(6);
            llist.push(7);
            llist.push(1);
            llist.append(4);
            llist.insertAfter(llist.head.next, 8);

            Console.Write("Created Linked list is: ");
            llist.printList();

            llist.deleteNode(1);
            Console.Write("\nLinked List after Deletion of 1: ");
            llist.printList();
        }
    }
}
