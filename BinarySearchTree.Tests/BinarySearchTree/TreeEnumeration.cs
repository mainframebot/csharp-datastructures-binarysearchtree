using NUnit.Framework;

namespace BinarySearchTree.Tests.BinarySearchTree
{
    [TestFixture]
    public class TreeEnumeration : Base
    {
        [Test]
        public void Enumeration_Should_TraverseTree_InOrder()
        {
            int index = 0;

            foreach (var item in BinarySearchTree)
            {
                Assert.That(ItemsInOrder[index++], Is.EqualTo(item));
            }
        }
    }
}
