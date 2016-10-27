using System;
using Csharp.DataStructure.LinarList.Interface;

namespace Csharp.DataStructure.LinarList
{
    /// <summary>
    /// 双链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoubleLinkedList<T> : ILinarList<T>
    {
        /// <summary>
        /// 链表开始节点
        /// </summary>
        public DNode<T> Start { get; set; }
        /// <summary>
        /// 链表长度
        /// </summary>
        public int Length { get; private set; }

        public DoubleLinkedList()
        {
            Start = null;
            Length = 0;
        }
        #region Implementation of ILinarList<T>

        /// <summary>
        /// 插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="position"></param>
        public void InsertNode(T node, int position)
        {
            if (position < 1 || position > Length + 1)
            {
                return; ;
            }
            DNode<T> newNode = new DNode<T>(node);
            if (IsEmpty() || position == 1)
            {
                newNode.Next = Start;
                Start = newNode;
                Length++;
            }
            else
            {
                DNode<T> current = Start;
                DNode<T> previous = null;
                int i = 1;//计数器
                //从第一个节点通过遍历找到插入位置的前一个节点
                while (current.Next != null && i++ < position)
                {
                    previous = current;
                    current = current.Next;
                }
                if (i == position && previous != null)
                {
                    previous.Next = newNode;
                    current.Previous = newNode;
                    newNode.Previous = previous;
                    newNode.Next = current;
                }
            }
        }

        /// <summary>
        /// 在末尾插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public void InsertNode(T node)
        {
            var newNode = new DNode<T>(node);
            if (IsEmpty())
            {
                Start = newNode;
                Length++;
                return;
            }
            DNode<T> current = Start;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Previous = current;
            newNode.Next = null;
            Length++;
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="position"></param>
        public void DeleteNode(int position)
        {
            if (IsEmpty()||position < 1 || position > Length)
            {
                return;
            }
            DNode<T> current = Start;
            DNode<T> previous = null;
            if (position == 1)
            {
                Start = current.Next;
                Start.Previous = null;
                Length--;
            }
            else
            {
                int i = 1;//计数器
                while (current.Next != null && i < position)
                {
                    previous = current;
                    current = current.Next;
                    i++;
                }
                if (i==position&&previous!=null&&current.Next!=null)
                {
                    previous.Next = current.Next;
                    current.Next.Previous = previous;
                    Length--;
                }
            }
        }

        /// <summary>
        /// 通过位置搜索节点
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T SearchNode(int position)
        {
            T data = default(T);
            if (IsEmpty()) return data;
            DNode<T> current = Start;
            int i = 1;//计数器
            while (current.Next!=null&&i++<position)
            {
                current = current.Next;
            }
            if (i==position)
            {
                data = current.Data;
            }
            return data;
        }

        /// <summary>
        /// 通过结点内容搜索节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T SearchNode(T node)
        {
            T data = default(T);
            if (IsEmpty()) return data;
            DNode<T> current = Start;
            int i = 1;//计数器
            while (current.Next != null && !current.Data.ToString().Contains(data.ToString())) //这里没有定位，所以最差的情况是遍历整个表
            {
                current = current.Next;
                i++;
            }
            data =  current.Data;
            return data;
        }

        /// <summary>
        /// 获得长度
        /// </summary>
        /// <returns></returns>
        public int GetLength()
        {
            return Length;
        }

        /// <summary>
        /// 清空
        /// </summary>
        public void Clear()
        {
            Start = null;
            Length = 0;
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Start == null;
        }

        #endregion
    }
}
