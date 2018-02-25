using System;
using BinarySearchTree.Models;

namespace BinarySearchTree.Interfaces
{
    public interface ITreeDelete<T>
        where T : IComparable<T>
    {
        bool Delete(Node<T> node);
    }
}
