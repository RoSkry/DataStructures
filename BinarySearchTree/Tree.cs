﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Tree<T> where T : IComparable, IComparable<T>
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        public List<T> PreOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return PreOrder(Root);
        }

        public List<T> PostOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return PostOrder(Root);
        }

        public List<T> InOrder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return InOrder(Root);
        }

        private List<T> PreOrder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                list.Add(node.Data);

                if (node.Left != null)
                {
                    list.AddRange(PreOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PreOrder(node.Right));
                }
            }

            return list;
        }

        private List<T> PostOrder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(PostOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PostOrder(node.Right));
                }

                list.Add(node.Data);
            }

            return list;
        }

        private List<T> InOrder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }
            }

            return list;
        }


    }
}
