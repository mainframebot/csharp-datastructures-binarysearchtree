using System;
using BinarySearchTree.Models;

namespace BinarySearchTree.Interfaces
{
    public interface ITreeInsert<T>
        where T : IComparable<T>
    {
        Node<T> Insert(Node<T> node);
    }
}
