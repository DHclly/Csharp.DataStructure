using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.DataStructure.LinarList
{
    /// <summary>
    /// 单链表结点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SNode<T>
    {
        /// <summary>
        /// 数据域
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 下一个节点指针
        /// </summary>
        public SNode<T> Next { get; set; }
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public SNode()
        {
            Data = default(T);
            Next = null;
        }

        /// <summary>
        /// 非默认构造函数
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="next">下一个节点</param>
        public SNode(T data, SNode<T> next)
        {
            Data = data;
            Next = next;
        }

        /// <summary>
        /// 非默认构造函数
        /// </summary>
        /// <param name="next">下一个节点</param>
        public SNode(SNode<T> next)
        {
            Next = next;
            Data = default(T);
        }

        /// <summary>
        /// 非默认构造函数
        /// </summary>
        /// <param name="data">数据</param>
        public SNode(T data)
        {
            Data = data;
            Next = null;
        }

    }
}
