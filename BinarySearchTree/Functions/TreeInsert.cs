using System;
using BinarySearchTree.Interfaces;
using BinarySearchTree.Models;

namespace BinarySearchTree.Functions
{
    public class TreeInsert<T> : ITreeInsert<T>
        where T : IComparable<T>
    {
        private readonly BinarySearchTree<T> _tree;
         
        public TreeInsert(BinarySearchTree<T> tree)
        {
            _tree = tree;
        }

        public Node<T> Insert(Node<T> node)
        {
            if (node == null)
                throw new ArgumentNullException();

            if (_tree.Root == null)
            {
                _tree.Root = node;
            }
            else
            {
                InsertNode(_tree.Root, node);
            }

            _tree.Count++;

            return node;
        }

        private void InsertNode(Node<T> current, Node<T> node)
        {
            node.Parent = current;

            if (node.Value.CompareTo(current.Value) < 0)
            {
                if (current.Left == null)
                {
                    current.Left = node;
                }
                else
                {
                    InsertNode(current.Left, node);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = node;
                }
                else
                {
                    InsertNode(current.Right, node);
                }
            }
        }
    }
}
