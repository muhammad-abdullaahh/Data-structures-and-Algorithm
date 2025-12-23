namespace labTask01
{
    internal class Array_Tree
    {
        public int size = 10;
        public string[] tree = new string[10];

        public void Root(string key)
        {
            tree[0] = key;
        }

        public void setLeft(string key, int root)
        {
            int t = (root * 2) + 1;
            if (tree[root] == null)
            {
                Console.WriteLine("The root cannot be null");
            }
            else
            {
                tree[t] = key;
            }
        }

        public void setRight(string key, int root)
        {
            int t = (root * 2) + 2;
            if (tree[root] == null)
            {
                Console.WriteLine("Root cannot be null");
            }
            else
            {
                tree[t] = key;
            }
        }

        public void printTree()
        {
            for (int i = 0; i < tree.Length; i++)
            {
                if (tree[i] != null)
                    Console.WriteLine(tree[i]);
                else
                    Console.WriteLine("-");
            }
        }

        public void inorderTraversal(int index)
        {
            if (index >= size || tree[index]==null)
            {
                return;
            }
            inorderTraversal(2 * index + 1);
            Console.WriteLine(tree[index]+" ");
            inorderTraversal(2*index+2);
        }

        public void preorderTraversal(int index)
        {
            if (index >= size || tree[index] == null)
            {
                return;
            }
            Console.WriteLine(tree[index] + " ");
            inorderTraversal(2 * index + 1);
            inorderTraversal(2 * index + 2);
        }

        public void postorderTraversal(int index)
        {
            if (index >= size || tree[index] == null)
            {
                return;
            }
            inorderTraversal(2 * index + 1);
            inorderTraversal(2 * index + 2);
            Console.WriteLine(tree[index] + " ");
        }
    }
}