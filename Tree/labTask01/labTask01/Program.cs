using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            Array_Tree obj = new Array_Tree();

            obj.Root("Grandfather");    // index 0
            obj.setLeft("Left child of grandfather (left parent)", 0);   // index 1
            obj.setRight("Right child of grandfather (right parent)", 0); // index 2
            obj.setLeft("Left child of left parent", 1);   // index 3
            obj.setRight("Right child of left parent", 1); // index 4
            obj.setLeft("Left child of right parent", 2);  // index 5 
            obj.setRight("Right child of right parent", 2); // index 6 

            obj.printTree();

            Console.WriteLine("Inoreder Traversal");
            obj.inorderTraversal(0);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Preorder Traversal");
            obj.preorderTraversal(0);
            Console.WriteLine();
            Console.WriteLine();

           Console.WriteLine("Postorder Traversal");
            obj.postorderTraversal(0);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}