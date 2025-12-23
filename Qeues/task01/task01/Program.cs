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
            queue q = new queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Display();
            q.Dequeue();
            q.Display();
            q.Dequeue();
            q.Dequeue();
            q.Display();
            q.Enqueue(40);
            q.Peek();
        }
    }
}
