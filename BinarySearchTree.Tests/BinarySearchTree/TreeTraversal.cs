using NUnit.Framework;

namespace BinarySearchTree.Tests.BinarySearchTree
{
    [TestFixture]
    public class TreeTraversal : Base
    {
        [Test]
        public void PreOrderTraversal_Should_Traverse_In_Correct_Order()
        {
            int index = 0;

            BinarySearchTree.PreOrderTraversal(item => Assert.That(ItemsPreOrder[index++], Is.EqualTo(item)));
        }

        [Test]
        public void InOrderTraversal_Should_Traverse_In_Correct_Order()
        {
            int index = 0;

            BinarySearchTree.InOrderTraversal(item => Assert.That(ItemsInOrder[index++], Is.EqualTo(item)));
        }

        [Test]
        public void PostOrderTraversal_Should_Traverse_In_Correct_Order()
        {
            int index = 0;

            BinarySearchTree.PostOrderTraversal(item => Assert.That(ItemsPostOrder[index++], Is.EqualTo(item)));
        }
    }
}
