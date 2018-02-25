using System;
using BinarySearchTree.Interfaces;
using BinarySearchTree.Models;

namespace BinarySearchTree.Functions
{
    public class TreeDelete<T> : ITreeDelete<T>
        where T : IComparable<T>
    {
        private readonly BinarySearchTree<T> _tree;
        private readonly ITreeSearch<T> _treeSearch; 

        public TreeDelete(BinarySearchTree<T> tree, ITreeSearch<T> treeSearch)
        {
            if(tree == null || treeSearch == null)
                throw new ArgumentNullException();

            _tree = tree;
            _treeSearch = treeSearch;  
        }

        public bool Delete(Node<T> node)
        {
            if (node.Left == null)
            {
                Transplant(node, node.Right);
            }
            else if (node.Right == null)
            {
                Transplant(node, node.Left);
            }
            else
            {
                var leftmostNode = _treeSearch.Minimum(node.Right);

                if (leftmostNode.Parent != node)
                {
                    Transplant(leftmostNode, leftmostNode.Right);
                    leftmostNode.Right = node.Right;
                    leftmostNode.Right.Parent = leftmostNode;
                }

                Transplant(node, leftmostNode);
                leftmostNode.Left = node.Left;
                leftmostNode.Left.Parent = leftmostNode;
            }

            _tree.Count--;

            return true;
        }

        private void Transplant(Node<T> deletedNode, Node<T> replacementNode)
        {
            if (deletedNode.Parent == null)
            {
                _tree.Root = replacementNode;
            }
            else if (deletedNode == deletedNode.Parent.Left)
            {
                deletedNode.Parent.Left = replacementNode;
            }
            else
            {
                deletedNode.Parent.Right = replacementNode;
            }

            if (replacementNode != null)
            {
                replacementNode.Parent = deletedNode.Parent;
            }
        }
    }
}
