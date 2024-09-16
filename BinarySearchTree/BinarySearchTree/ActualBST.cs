using System;
namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public Node<T> Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(T data)
        {
            Root = InsertRec(Root, data);
        }

        private Node<T> InsertRec(Node<T> root, T data)
        {
            if (root == null)
            {
                root = new Node<T>(data);
                return root;
            }

            if (data.CompareTo(root.Data) < 0)
                root.Left = InsertRec(root.Left, data);
            else
                root.Right = InsertRec(root.Right, data);

            return root;
        }

        public Node<T> Search(T key)
        {
            return SearchRec(Root, key);
        }

        private Node<T> SearchRec(Node<T> root, T key)
        {
            if (root == null || root.Data.CompareTo(key) == 0)
                return root;

            if (key.CompareTo(root.Data) < 0)
                return SearchRec(root.Left, key);

            return SearchRec(root.Right, key);
        }

        public void Inorder()
        {
            InorderRec(Root);
        }

        private void InorderRec(Node<T> root)
        {
            if (root != null)
            {
                InorderRec(root.Left);
                Console.WriteLine(root.Data.ToString());
                InorderRec(root.Right);
            }
        }
    }

}

