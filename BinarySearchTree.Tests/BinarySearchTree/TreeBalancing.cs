using System;
using System.Collections.Generic;
using System.Linq;
using BinarySearchTree.Models;
using NUnit.Framework;

namespace BinarySearchTree.Tests.BinarySearchTree
{
    [TestFixture]
    public class TreeBalancing : Base
    {
        [Test]
        public void Balancing_Should_Generate_Valid_Random_Tree_With_BinarySearchTree_Properties()
        {
            var tree = GenerateRandomTree();

            TreeNodeInOrderTraversal(tree.Root, x =>
            {
                var left = new List<int>();
                var right = new List<int>();

                if (x.Left != null)
                {
                    TreeNodeInOrderTraversal(x.Left, node => left.Add(node.Value));

                    Assert.That(left.Any(node => node >= x.Value), Is.False);
                }

                if (x.Right != null)
                {
                    TreeNodeInOrderTraversal(x.Right, node => right.Add(node.Value));

                    Assert.That(right.Any(node => node < x.Value), Is.False);
                }
            });
        }

        private void TreeNodeInOrderTraversal(Node<int> node, Action<Node<int>> action)
        {
            if (node != null)
            {
                TreeNodeInOrderTraversal(node.Left, action);
                action(node);
                TreeNodeInOrderTraversal(node.Right, action);
            }
        }
    }
}
