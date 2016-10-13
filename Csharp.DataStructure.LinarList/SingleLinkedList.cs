using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csharp.DataStructure.LinarList.Interface;

namespace LinarList
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SingleLinkedList<T> : ILinarList<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private class SNode<T>
        {
            /// <summary>
            /// 
            /// </summary>
            public T Data { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public SNode<T> Next { get; set; }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="data"></param>
            /// <param name="next"></param>
            public SNode(T data, SNode<T> next)
            {
                this.Data = data;
                this.Next = next;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="next"></param>
            public SNode(SNode<T> next)
            {
                this.Next = next;
            }

            /// <summary>
            /// 
            /// </summary>
            public SNode()
            {
                this.Data = default(T);
                this.Next = null;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void DeleteNode(int position)
        {
            throw new NotImplementedException();
        }

        public int GetLength()
        {
            throw new NotImplementedException();
        }

        public void InsertNode(T node, int position)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public T SearchNode(T node)
        {
            throw new NotImplementedException();
        }

        public T SearchNode(int position)
        {
            throw new NotImplementedException();
        }
    }
}
