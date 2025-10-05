using System;
using task02;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack list = new Stack();
            Console.WriteLine("Reversing 'ABDULLAH'");
            list.push('A');
            list.push('B');
            list.push('D');
            list.push('U');
            list.push('L');
            list.push('L');
            list.push('A');
            list.push('H');
            Console.WriteLine("Reversed string: ");
            list.displayStack();
        }
    }
}
