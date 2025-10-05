using System;
using task01; 

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            Console.WriteLine("Using push method to push five elements...");
            myStack.push(50);
            myStack.push(40);
            myStack.push(30);
            myStack.push(20);
            myStack.push(10);
            myStack.displayStack();
            myStack.countItems();
            Console.WriteLine("Using pop method to pop two elements...");
            myStack.pop();
            myStack.pop();
            myStack.displayStack();
            myStack.countItems();
            Console.WriteLine("Is the stack full ? "+myStack.isFull());
            myStack.pop();
            myStack.pop();
            myStack.pop();
            Console.WriteLine("After popping three more elements...");
            Console.WriteLine("Is my stack empty ? "+myStack.isEmpty());

        }
    }
}
