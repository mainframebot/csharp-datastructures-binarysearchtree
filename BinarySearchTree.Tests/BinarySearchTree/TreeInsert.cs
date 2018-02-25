﻿using NUnit.Framework;

namespace BinarySearchTree.Tests.BinarySearchTree
{
    [TestFixture]
    public class TreeInsert : Base
    {
        [Test]
        public void Insert_Should_Generate_Valid_Tree()
        {
            var tree = BinarySearchTree;

            // Root

            Assert.That(tree.Root.Parent, Is.Null);
            Assert.That(tree.Root.Value, Is.EqualTo(50));

            // Root.Left

            Assert.That(tree.Root.Left.Parent, Is.EqualTo(tree.Root));
            Assert.That(tree.Root.Left.Value, Is.EqualTo(20));

            // Root.Left.Left

            Assert.That(tree.Root.Left.Left.Parent, Is.EqualTo(tree.Root.Left));
            Assert.That(tree.Root.Left.Left.Value, Is.EqualTo(10));

            Assert.That(tree.Root.Left.Left.Left.Parent, Is.EqualTo(tree.Root.Left.Left));
            Assert.That(tree.Root.Left.Left.Left.Value, Is.EqualTo(5));

            Assert.That(tree.Root.Left.Left.Right.Parent, Is.EqualTo(tree.Root.Left.Left));
            Assert.That(tree.Root.Left.Left.Right.Value, Is.EqualTo(15));

            // Root.Left.Right

            Assert.That(tree.Root.Left.Right.Parent, Is.EqualTo(tree.Root.Left));
            Assert.That(tree.Root.Left.Right.Value, Is.EqualTo(40));

            Assert.That(tree.Root.Left.Right.Left.Parent, Is.EqualTo(tree.Root.Left.Right));
            Assert.That(tree.Root.Left.Right.Left.Value, Is.EqualTo(35));

            Assert.That(tree.Root.Left.Right.Right.Parent, Is.EqualTo(tree.Root.Left.Right));
            Assert.That(tree.Root.Left.Right.Right.Value, Is.EqualTo(45));

            // Root.Right

            Assert.That(tree.Root.Right.Parent, Is.EqualTo(tree.Root));
            Assert.That(tree.Root.Right.Value, Is.EqualTo(80));

            // Root.Right.Left

            Assert.That(tree.Root.Right.Left.Parent, Is.EqualTo(tree.Root.Right));
            Assert.That(tree.Root.Right.Left.Value, Is.EqualTo(70));

            Assert.That(tree.Root.Right.Left.Left.Parent, Is.EqualTo(tree.Root.Right.Left));
            Assert.That(tree.Root.Right.Left.Left.Value, Is.EqualTo(65));

            Assert.That(tree.Root.Right.Left.Right.Parent, Is.EqualTo(tree.Root.Right.Left));
            Assert.That(tree.Root.Right.Left.Right.Value, Is.EqualTo(75));

            // Root.Right.Right

            Assert.That(tree.Root.Right.Right.Parent, Is.EqualTo(tree.Root.Right));
            Assert.That(tree.Root.Right.Right.Value, Is.EqualTo(90));

            Assert.That(tree.Root.Right.Right.Left.Parent, Is.EqualTo(tree.Root.Right.Right));
            Assert.That(tree.Root.Right.Right.Left.Value, Is.EqualTo(85));

            Assert.That(tree.Root.Right.Right.Right.Parent, Is.EqualTo(tree.Root.Right.Right));
            Assert.That(tree.Root.Right.Right.Right.Value, Is.EqualTo(95));

            // Count

            Assert.That(tree.Count, Is.EqualTo(Items.Length));
        }

        [Test]
        public void Insert_Should_Place_Item_Less_Than_Parent_Left()
        {
            var tree = BinarySearchTree;

            // Duplicate value

            tree.Insert(ItemsInsertLessThanParent);

            Assert.That(tree.Root.Right.Right.Right.Left.Parent, Is.EqualTo(tree.Root.Right.Right.Right));
            Assert.That(tree.Root.Right.Right.Right.Left.Value, Is.EqualTo(94));

            // Count

            Assert.That(tree.Count, Is.EqualTo(Items.Length + 1));
        }

        [Test]
        public void Insert_Should_Place_Item_Equal_To_Parent_Right()
        {
            var tree = BinarySearchTree;

            // Duplicate value

            tree.Insert(ItemsInsertEqualToParent);

            Assert.That(tree.Root.Right.Right.Right.Right.Parent, Is.EqualTo(tree.Root.Right.Right.Right));
            Assert.That(tree.Root.Right.Right.Right.Right.Value, Is.EqualTo(95));

            // Count

            Assert.That(tree.Count, Is.EqualTo(Items.Length + 1));
        }

        [Test]
        public void Insert_Should_Place_Item_Greater_Than_Parent_Right()
        {
            var tree = BinarySearchTree;

            // Duplicate value

            tree.Insert(ItemsInsertGreaterThanParent);

            Assert.That(tree.Root.Right.Right.Right.Right.Parent, Is.EqualTo(tree.Root.Right.Right.Right));
            Assert.That(tree.Root.Right.Right.Right.Right.Value, Is.EqualTo(96));

            // Count

            Assert.That(tree.Count, Is.EqualTo(Items.Length + 1));
        }
    }
}
