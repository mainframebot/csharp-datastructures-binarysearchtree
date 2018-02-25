﻿using System;
using BinarySearchTree.Models;

namespace BinarySearchTree.Interfaces
{
    public interface ITreeTraversal<T>
        where T : IComparable<T>
    {
        void PreOrderTraversal(Node<T> node, Action<T> action);

        void InOrderTraversal(Node<T> node, Action<T> action);

        void PostOrderTraversal(Node<T> node, Action<T> action);
    }
}
