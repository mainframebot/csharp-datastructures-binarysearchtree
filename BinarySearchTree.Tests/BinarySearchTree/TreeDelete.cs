using NUnit.Framework;

namespace BinarySearchTree.Tests.BinarySearchTree
{
    [TestFixture]
    public class TreeDelete : Base
    {
        [Test]
        public void Delete_Should_Generate_Valid_Tree_When_Triggering_DeleteCase1()
        {
            var tree = BinarySearchTreeDeleteCase1;

            var node = tree.Search(DeleteCase1Item);

            tree.Delete(node);

            // Root

            Assert.That(tree.Root.Parent, Is.Null);
            Assert.That(tree.Root.Value, Is.EqualTo(50));

            // Root.Right

            Assert.That(tree.Root.Right.Parent, Is.EqualTo(tree.Root));
            Assert.That(tree.Root.Right.Value, Is.EqualTo(90));

            // Root.Right.Left

            Assert.That(tree.Root.Right.Left.Parent, Is.EqualTo(tree.Root.Right));
            Assert.That(tree.Root.Right.Left.Value, Is.EqualTo(85));

            // Root.Right.Right

            Assert.That(tree.Root.Right.Right.Parent, Is.EqualTo(tree.Root.Right));
            Assert.That(tree.Root.Right.Right.Value, Is.EqualTo(95));

            // Count

            Assert.That(tree.Count, Is.EqualTo(DeleteCase1Items.Length - 1));
        }

        [Test]
        public void Delete_Should_Generate_Valid_Tree_When_Triggering_DeleteCase2()
        {
            var tree = BinarySearchTreeDeleteCase2;

            var node = tree.Search(DeleteCase2Item);

            tree.Delete(node);

            // Root

            Assert.That(tree.Root.Parent, Is.Null);
            Assert.That(tree.Root.Value, Is.EqualTo(50));

            // Root.Right

            Assert.That(tree.Root.Right.Parent, Is.EqualTo(tree.Root));
            Assert.That(tree.Root.Right.Value, Is.EqualTo(70));

            // Root.Right.Left

            Assert.That(tree.Root.Right.Left.Parent, Is.EqualTo(tree.Root.Right));
            Assert.That(tree.Root.Right.Left.Value, Is.EqualTo(65));

            // Root.Right.Right

            Assert.That(tree.Root.Right.Right.Parent, Is.EqualTo(tree.Root.Right));
            Assert.That(tree.Root.Right.Right.Value, Is.EqualTo(75));

            // Count

            Assert.That(tree.Count, Is.EqualTo(DeleteCase2Items.Length - 1));
        }

        [Test]
        public void Delete_Should_Generate_Valid_Tree_When_Triggering_DeleteCase3()
        {
            var tree = BinarySearchTreeDeleteCase3;

            var node = tree.Search(DeleteCase3Item);

            tree.Delete(node);

            // Root

            Assert.That(tree.Root.Parent, Is.Null);
            Assert.That(tree.Root.Value, Is.EqualTo(50));

            // Root.Right

            Assert.That(tree.Root.Right.Parent, Is.EqualTo(tree.Root));
            Assert.That(tree.Root.Right.Value, Is.EqualTo(85));

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

            Assert.That(tree.Root.Right.Right.Left, Is.Null);

            Assert.That(tree.Root.Right.Right.Right.Parent, Is.EqualTo(tree.Root.Right.Right));
            Assert.That(tree.Root.Right.Right.Right.Value, Is.EqualTo(95));

            // Count

            Assert.That(tree.Count, Is.EqualTo(DeleteCase3Items.Length - 1));
        }
    }
}
