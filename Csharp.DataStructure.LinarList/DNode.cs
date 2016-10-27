using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DataStructure.LinarList
{
    /// <summary>
    /// 双链表结点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DNode<T>
    {
        /// <summary>
        /// 数据域
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 上一个节点指针
        /// </summary>
        public DNode<T> Previous { get; set; }
        /// <summary>
        /// 下一个节点指针
        /// </summary>
        public DNode<T> Next { get; set; }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public DNode()
        {
            Data = default(T);
            Next = null;
            Previous = null;
        }

        /// <summary>
        /// 非默认构造函数
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="prev">上一个节点</param>
        /// <param name="next">下一个节点</param>
        public DNode(T data, DNode<T> prev, DNode<T> next) : this()
        {
            Data = data;
            Next = next;
            Previous = prev;
        }

        /// <summary>
        /// 非默认构造函数
        /// </summary>
        /// <param name="data">数据</param>
        public DNode(T data) : this()
        {
            Data = data;
            Previous = null;
            Next = null;
        }
    }
}
