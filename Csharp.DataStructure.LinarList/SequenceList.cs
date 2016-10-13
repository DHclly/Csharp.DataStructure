using Csharp.DataStructure.LinarList.Interface;

namespace Csharp.DataStructure.LinarList
{
    /// <summary>
    /// 顺序表
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SequenceList<T> : ILinarList<T>
    {
        /// <summary>
        /// 存储数据的最大容量
        /// </summary>
        public int MaxSize { get; set; }
        /// <summary>
        /// 存储的数据
        /// </summary>
        private T[] Data { get; set; }
        /// <summary>
        /// 顺序表实际长度
        /// </summary>
        public int Length { get; private set; }
        /// <summary>
        /// 使默认构造函数私有，即禁用
        /// </summary>
        private SequenceList() { }
        public SequenceList(int maxsize)
        {
            MaxSize = maxsize;
            Length = 0;
            Data = new T[MaxSize];
        }
        /// <summary>
        /// 获取一个顺序表实例
        /// </summary>
        /// <param name="maxsize"></param>
        /// <returns></returns>
        public static SequenceList<T> GetInstance(int maxsize)
        {
            return new SequenceList<T>(maxsize);
        }
        #region Implementation of ILinarList<T>

        /// <summary>
        /// 插入节点(最小为1)
        /// </summary>
        /// <param name="node"></param>
        /// <param name="position"></param>
        public void InsertNode(T node, int position)
        {
            if (position == 1 && Length == 0)
            {
                Data[position - 1] = node;
            }
            else if (position - 1 == Length)
            {
                Data[Length] = node;
            }
            else
            {
                for (int i = Length - 1; i >= position - 1; i--)
                {
                    Data[i + 1] = Data[i];
                }
                Data[position - 1] = node;
            }
            Length++;
        }

        /// <summary>
        /// 在末尾插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public void InsertNode(T node)
        {
            InsertNode(node,Length);
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="position"></param>
        public void DeleteNode(int position)
        {
            for (int i = position; i < Length; i++)
            {
                Data[i-1] = Data[i];
            }
            Length--;
        }

        /// <summary>
        /// 通过位置搜索节点
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public T SearchNode(int position)
        {
            return Data[position - 1];
        }

        /// <summary>
        /// 通过结点内容搜索节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public T SearchNode(T node)
        {
            for (int i = 0; i < Length; i++)
            {
                if (Data[i].ToString().Equals(node.ToString()))
                {
                    return Data[i];
                }
            }
            return default(T);
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
            Length = 0;
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Length == 0;
        }
        /// <summary>
        /// 判断是否为满
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            return Length == MaxSize;
        }
        #endregion
    }
}
