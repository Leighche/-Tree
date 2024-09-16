using System;
namespace BinarySearchTree
{
    public class Node<T> where T : IComparable<T>
    {
        public T Data;
        public Node<T> Left, Right;

        public Node(T item)
        {
            Data = item;
            Left = Right = null;
        }
    }
}

