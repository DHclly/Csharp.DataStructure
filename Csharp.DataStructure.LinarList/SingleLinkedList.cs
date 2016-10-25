using Csharp.DataStructure.LinarList.Interface;

namespace Csharp.DataStructure.LinarList
{
    /// <summary>
    /// 单链表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T> : ILinarList<T>
    {
        /// <summary>
        /// 链表开始节点
        /// </summary>
        public SNode<T> Start { get; set; }
        /// <summary>
        /// 链表长度
        /// </summary>
        public int Length { get; private set; }

        public SingleLinkedList()
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
            var newNode = new SNode<T>(node);
            if (position == 1)
            {
                //链表中有一个元素的情况和空链表的情况
                newNode.Next = Start;
                Start = newNode;
                Length++;
            }
            else
            {
                int i = 1;//计数器
                var current = Start;
                SNode<T> previous = null;
                //从第一个节点通过遍历找到插入位置的前一个节点
                while (current != null && i++ < position)
                {
                    previous = current;
                    current = current.Next;
                }
                //找到前一个节点时，i自增，此时等于position
                //同时要保证找到了插入节点的前一个不为null
                if (i == position && previous != null)
                {
                    previous.Next = newNode;
                    newNode.Next = current;
                    Length++;
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
            var newNode = new SNode<T>(node);
            if (IsEmpty())
            {
                Start = newNode;
                Length++;
            }
            else
            {
                var current = Start;
                while (current.Next != null) //遍历到末尾的元素
                {
                    current = current.Next;
                }
                current.Next = newNode;
                Length++;
            }
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="position"></param>
        public void DeleteNode(int position)
        {
            if (!IsEmpty() && position >= 1 && position <= Length)
            {
                var current = Start;
                if (position == 1)
                {
                    Start = current.Next;
                    Length--;
                }
                else
                {
                    int i = 1;//计数器
                    SNode<T> previous = null;
                    //从第一个节点通过遍历找到删除位置的前一个节点
                    while (current.Next != null && i++ < position)
                    {
                        previous = current;
                        current = current.Next;
                    }
                    //找到前一个节点时，i自增，此时等于position
                    //同时要保证找到了删除节点的前一个不为null
                    if (i == position && previous != null)
                    {
                        previous.Next = current.Next;
                        Length--;
                    }
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
            if (!IsEmpty() && position >= 1 && position <= Length)
            {
                int i = 1;//计数器
                var current = Start;
                //从第一个节点通过遍历找到搜索位置的前一个节点
                while (current.Next != null && i++ < position)
                {
                    current = current.Next;
                }
                //找到前一个节点时，i自增，此时等于position
                //同时要保证找到了搜索节点的前一个不为null
                if (i == position)
                {
                    data = current.Data;
                }
            }
            return data;
        }

        /// <summary>
        /// 通过结点内容搜索节点(尝试通过ToString后查找)
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T SearchNode(T node)
        {
            T data = default(T);
            if (!IsEmpty())
            {
                var current = Start;
                while (!current.Data.ToString().Equals(node.ToString()))
                {
                    current = current.Next;
                }
                data = current.Data;
            }
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
