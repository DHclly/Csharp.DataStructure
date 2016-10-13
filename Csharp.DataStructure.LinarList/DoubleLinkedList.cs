using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csharp.DataStructure.LinarList.Interface;

namespace LinarList
{
    class DoubleLinkedList<T> : ILinarList<T>
    {
        private class DbNode<U>
        {
            public U Data { get; set; }
            public DbNode<U> Previous { get; set; }
            public DbNode<U> Next { get; set; }

            public DbNode(U data, DbNode<U> next) : this()
            {
                this.Data = data;
                this.Next = next;
            }

            public DbNode(U data):this()
            {
                this.Data = data;
                this.Next = null;
            }

            public DbNode(DbNode<U> next ):this()
            {
                this.Data = default(U);
                this.Next = next;
            }

            public DbNode()
            {
                this.Data = default(U);
                this.Next = null;
                this.Previous = null;
            }
        }
        
    }
}
