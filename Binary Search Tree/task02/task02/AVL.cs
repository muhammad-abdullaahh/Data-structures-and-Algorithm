using System;
using System.Collections.Generic;
using System.Text;

namespace task02
{
	internal class AVL
	{
		public Node root;
		public AVL()
		{
			root = null;
		}
		public void Add(int data)
		{
			root = Insert(root, new Node(data));
		}
		private Node Insert(Node root, Node newItem)
		{
			if (root == null)
				return newItem;
			if (newItem.data < root.data)
				root.left = Insert(root.left, newItem);
			else if (newItem.data > root.data)
				root.right = Insert(root.right, newItem);
			return CheckBalance(root);
		}
		private int Depth(Node root)
		{
			if (root == null)
				return 0;
			return Math.Max(Depth(root.left), Depth(root.right)) + 1;
		}
		private int Difference(Node root)
		{
			return Depth(root.left) - Depth(root.right);

		}
		private Node CheckBalance(Node root)
		{
			int balance = Difference(root);
			if (balance > 1)
			{
				if (Difference(root.left) > 0)
					return RotateLL(root);
				else
					return RotateLR(root);
			}
			if (balance < -1)
			{
				if (Difference(root.right) < 0)
					return RotateRR(root);
				else
					return RotateRL(root);
			}
			return root;
		}
		private Node RotateLL(Node parent)
		{
			Node child = parent.left;
			parent.left = child.right;
			child.right = parent;
			return child;
		}
		private Node RotateRR(Node parent)
		{
			Node child = parent.right;
			parent.right = child.left;
			child.left = parent;
			return child;
		}
		private Node RotateLR(Node parent)
		{
			parent.left = RotateRR(parent.left);
			return RotateLL(parent);
		}
		private Node RotateRL(Node parent)
		{
			parent.right = RotateLL(parent.right);
			return RotateRR(parent);
		}
		public String Find(int key)
		{
			return Find(root, key);
		}
		private String Find(Node root, int key)
		{
			if (root == null)
				return "Value not found...";
			if (key == root.data)
				return "Value found...";
			else if (key < root.data)
				return Find(root.left, key);
			else
				return Find(root.right, key);
		}
		public void Display()
		{
			Console.Write("AVL Tree (Inorder): ");
			Inorder(root);
			Console.WriteLine();
		}
		private void Inorder(Node root)
		{
			if (root != null)
			{
				Inorder(root.left);
				Console.Write(root.data + " ");
				Inorder(root.right);
			}
		}
		public int Max()
		{
			if (root == null)
				return -1;
			Node current = root;
			while (current.right != null)
				current = current.right;
			return current.data;
		}
	}
}
