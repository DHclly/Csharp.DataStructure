using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csharp.DataStructure.LinarList.Interface;

namespace LinarList
{
    class DoubleLinkedList<T> : ILinarList<T>
    {
        private class DbNode<T>
        {
            public T Data { get; set; }
            public DbNode<T> Previous { get; set; }
            public DbNode<T> Next { get; set; }

            public DbNode(T data, DbNode<T> next) : this()
            {
                this.Data = data;
                this.Next = next;
            }

            public DbNode(T data):this()
            {
                this.Data = data;
                this.Next = null;
            }

            public DbNode(DbNode<T> next ):this()
            {
                this.Data = default(T);
                this.Next = next;
            }

            public DbNode()
            {
                this.Data = default(T);
                this.Next = null;
                this.Previous = null;
            }
        }
        public void InsertNode(T node, int position)
        {
            throw new NotImplementedException();
        }

        public void DeleteNode(int position)
        {
            throw new NotImplementedException();
        }

        public T SearchNode(int position)
        {
            throw new NotImplementedException();
        }

        public T SearchNode(T node)
        {
            throw new NotImplementedException();
        }

        public int GetLength()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }
    }
}
