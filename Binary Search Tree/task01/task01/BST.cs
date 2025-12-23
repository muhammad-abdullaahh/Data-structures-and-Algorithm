using System;
using System.Collections.Generic;
using System.Text;

namespace task01
{
    internal class BST
    {
		public Node root;
		public BST()
		{
			root = null;
		}
		public void Insert(int value)
		{
			root = InsertNode(root, value);
		}
		private Node InsertNode(Node root, int value)
		{
			if (root == null)
			{
				return new Node(value);
			}
			if (value < root.data)
			{
				root.left = InsertNode(root.left, value);
			}
			else if (value > root.data)
			{
				root.right = InsertNode(root.right, value);
			}
			return root;
		}
		public void Inorder()
		{
			InorderTree(root);
			Console.WriteLine();
		}
		private void InorderTree(Node root)
		{
			if (root != null)
			{
				InorderTree(root.left);
				Console.Write(root.data + " ");
				InorderTree(root.right);
			}
		}
		public void Preorder()
		{
			PreorderTree(root);
			Console.WriteLine();
		}
		private void PreorderTree(Node root)
		{
			if (root != null)
			{
				Console.Write(root.data + " ");
				PreorderTree(root.left);
				PreorderTree(root.right);
			}
		}
		public void Postorder()
		{
			PostorderTree(root);
			Console.WriteLine();
		}
		private void PostorderTree(Node root)
		{
			if (root != null)
			{
				PostorderTree(root.left);
				PostorderTree(root.right);
				Console.Write(root.data + " ");
			}
		}
		public String Search(int key)
		{
			Node current = root;
			while (current != null)
			{
				if (current.data == key)
					return "Value found...";
				if (key < current.data)
					current = current.left;
				else
					current = current.right;
			}
			return "Value not found...";
		}
	}
}

