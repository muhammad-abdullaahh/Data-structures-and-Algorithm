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
			BST tree = new BST();
			tree.Insert(8);
			tree.Insert(16);
			tree.Insert(80);
			tree.Insert(24);
			tree.Insert(48);
			tree.Insert(56);
			tree.Insert(62);
			Console.WriteLine("Inorder Traversal: ");
			tree.Inorder();
			Console.WriteLine("Preorder Traversal: ");
			tree.Preorder();
			Console.WriteLine("Postorder Traversal: ");
			tree.Postorder();
			Console.WriteLine("Search 80: " + tree.Search(80));
			Console.WriteLine("Search 4: " + tree.Search(4));
		}
	}
}
