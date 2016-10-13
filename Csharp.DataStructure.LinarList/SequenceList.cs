using System;
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
        public int Length { get; }
        /// <summary>
        /// 使默认构造函数私有，即禁用
        /// </summary>
        private SequenceList(){}
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
        /// 插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="position"></param>
        public bool InsertNode(T node, int position)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 在末尾插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool InsertNode(T node)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="position"></param>
        public bool DeleteNode(int position)
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
