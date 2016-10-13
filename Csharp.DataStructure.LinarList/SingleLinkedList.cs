using System;
using Csharp.DataStructure.LinarList.Interface;

namespace Csharp.DataStructure.LinarList
{
    /// <summary>
    /// 单链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class SingleLinkedList<T> : ILinarList<T>
    {
        public class Snode<U>
        {
            /// <summary>
            /// 数据域
            /// </summary>
            public U Data { get; set; }
            /// <summary>
            /// 引用域
            /// </summary>
            public Snode<U> Next { get; set; }

        }
        #region Implementation of ILinarList<T>

        /// <summary>
        /// 插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="position"></param>
        public void InsertNode(T node, int position)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 在末尾插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public void InsertNode(T node)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="position"></param>
        public void DeleteNode(int position)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 通过位置搜索节点
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T SearchNode(int position)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 通过结点内容搜索节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T SearchNode(T node)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获得长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 清空
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
